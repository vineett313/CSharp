using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp._4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnNamedParameterExampleClick(object sender, EventArgs e)
        {
            var derivedParameter = new DerivedClass();

            var namedParameter = (NamedParameter)derivedParameter;


            namedParameter.TestMethod(a: 1, b: "Hello");
            derivedParameter.TestMethod(a: 1, b: "Hello");

            
            namedParameter.TestMethod(a: 1, b: 5);
            derivedParameter.TestMethod(a: 1, b: 5);
        }

        private void OnOptionalParamterExampleClick(object sender, EventArgs e)
        {
            OptionalParameter obj = new OptionalParameter();

            // obj.TestMethod() : This is not allowed due to ambigious call

            // below will call the method with less paramter. 
            obj.TestMethod(1);
            obj.TestMethod(1, 2);
        }

        private void OnCoAndContraVarianceClick(object sender, EventArgs e)
        {
            CoAndContraVariance obj = new CoAndContraVariance();

            obj.ContraVarianceExample();

            obj.CoVarianceExample();
        }

        private void OnDynamicClick(object sender, EventArgs e)
        {
            dynamic test = "2345";

            test = true;

            test = 1234;

            test++;

            test.CallSomthing();
        }

        private void OnNewComplierOptionClick(object sender, EventArgs e)
        {
            MessageBox.Show("Introducing the Embeded introp type flag with the assembly. Switching it to true will not load the assembly instead will load the type defination.");
        }
    }
}
