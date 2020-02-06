using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Molar_Mass_Calculator
{
    public partial class MainForm : Form
    {
        private BindingSource _elementCollection = new BindingSource();  //LINQ table to datagridview
        private List<Element> _csvElements = new List<Element>();        //Collection of Elements
        //private Dictionary<string, int> uElements;                       //User's chemical formula elements

        public MainForm()
        {
            InitializeComponent();

            //Bind LINQ statements to datagridview
            dgv_Elements.DataSource = _elementCollection;

            //read loaded file
            string file = File.ReadAllText(@"Elements.csv");

            //Get each element in csv
            List<string> allElements = new List<string>(file.Split('\r','\n'));
            allElements = allElements.Where(s => s.Trim().Length > 0).ToList();

            //Parse each element in csv
            foreach(var element in allElements)
            {
                var cElement = element.Split(',');

                _csvElements.Add(new Element(cElement[0], cElement[1], int.Parse(cElement[3]), float.Parse(cElement[2])));
            }

            //Display periodic table
            PeriodicTable();
        }

        private void tbx_ChemicalFormula_TextChanged(object sender, EventArgs e)
        {
            string chemicalFormula = tbx_ChemicalFormula.Text;                                                           //User's chemical formula
            MatchCollection splitFormula = Regex.Matches(chemicalFormula, @"(?'Element'[A-Z][a-z]?)(?'Count'\d{0,3})");  //Chemical formula split into its elements
            Dictionary<string, int> uElements = new Dictionary<string, int>();                                           //Elements and their count
            int splitCount = 0;                                                                                          //Count of chars parsed from chemical formula
            float molarMass = 0;                                                                                         //Chemical formula molar mass

            //All elements
            foreach (Match element in splitFormula)
            {
                splitCount += element.ToString().Count(); //Count chars from parsed chemical formula
                int count = element.Groups["Count"].Length == 0 ? 1 : int.Parse(element.Groups["Count"].ToString()); //Count of current element

                //If element exists already
                if (uElements.ContainsKey(element.Groups["Element"].Value))
                {
                    //Add Count already added element
                    uElements[element.Groups["Element"].Value] += count;
                }
                else
                {
                    //Start add element to dictionary, start from its count
                   uElements[element.Groups["Element"].Value] = count;
                }
            }

            //Create LINQ join using chemical formula and periodic table
            var molarMassCalculator = from kvp in uElements
                                      join ele in _csvElements on kvp.Key equals ele.Symbol
                                      orderby kvp.Key
                                      select new
                                      {
                                          Name = ele.Name,
                                          Mass = ele.MolarMass,
                                          Count = kvp.Value,
                                          TotalMass = ele.MolarMass * kvp.Value
                                      };

            //Count molar mass of formula
            foreach(var item in molarMassCalculator)
            {
                molarMass += item.TotalMass;
            }

            //If the chemical formula not was fully parsed, bad
            if (splitCount < chemicalFormula.Count())
            {
                tbx_ChemicalFormula.BackColor = Color.LightCoral;
            }
            //If there are elements
            else if (uElements.Count() > 0)
            {
                //If all elements in chemical formula are found, good
                if (molarMassCalculator.Count() == uElements.Count())
                {
                    //Update datagridview to chemical formula
                    _elementCollection.DataSource = molarMassCalculator;
                    tbx_ChemicalFormula.BackColor = Color.LightGreen;
                }
                //If other problem, bad
                else
                {
                    tbx_ChemicalFormula.BackColor = Color.LightCoral;
                }
            }
            //If no chemical formula, display periodic table
            else
            {
                PeriodicTable();
                tbx_ChemicalFormula.BackColor = Color.White;
            }

            //Display molar mass
            lbl_MolarMass.Text = "Approx Molar Mass : " + molarMass.ToString("F4") + "gr/mol";
        }

        private void btn_SortByName_Click(object sender, EventArgs e)
        {
            //sort by name using LINQ orderby
            //directly from the grid data
            _elementCollection.DataSource = from x in _csvElements
                                            orderby x.Name
                                            select x;
        }

        private void btn_SortBySymbol_Click(object sender, EventArgs e)
        {
            //sort by symbols using LINQ orderby
            //directly from the grid data
            _elementCollection.DataSource = from x in _csvElements
                                            orderby x.Symbol.Length, x.Symbol
                                            select x;
        }

        private void btn_SortByAtomic_Click(object sender, EventArgs e)
        {
            //LINQ orderby atomic number
            _elementCollection.DataSource = from x in _csvElements
                                            orderby x.AtomicNumber
                                            select x;
        }

        private void PeriodicTable()
        {
            _elementCollection.DataSource = from ele in _csvElements
                                            select new
                                            {
                                                Name = ele.Name,
                                                Symbol = ele.Symbol,
                                                AtomicNumber = ele.AtomicNumber,
                                                Mass = ele.MolarMass
                                            };
        }
    }
}
