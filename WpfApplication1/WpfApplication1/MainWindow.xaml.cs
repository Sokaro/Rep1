using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    interface IMedicals
    {
        void Modify(int a,double b,double c);
        void AddDis(Disease a);
    }

    public abstract class Medicals
    {
        protected string name;
        protected int amount;
        protected string interchangeability;
        protected double price;
        protected string producer;
        protected double dosage;
        protected List<Disease> diseases;

        public Medicals() { name = ""; amount = 0; interchangeability = ""; price = 0.0; producer = ""; dosage = 0.0; }
        public Medicals(string name, int amount, string interchangeability, double price, string producer, double dosage)
        {
            this.name = name;
            this.amount = amount;
            this.interchangeability = interchangeability;
            this.producer = producer;
            this.dosage = dosage;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }
        public string Interchangeability
        {
            set { interchangeability = value; }
            get { return interchangeability; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public string Produces
        {
            set { producer = value; }
            get { return producer; }
        }
        public double Dosage
        {
            set { dosage = value; }
            get { return dosage; }
        }
    }

        public class Pills : Medicals,IMedicals
    {
        public string form="pills";

        public Pills() : base(){ form = "pills"; }
        public Pills(string name,int amount,string interchangeability,double price, string producer,string form,double dosage):base(name,amount,interchangeability,price,producer,dosage)
        {
         
        }

        public string Form
        {
            get { return form; }
        }

        public void Modify(int a,double b,double c)
        {
            amount = a;
            price = b;
            dosage = c;
        }

        public void AddDis(Disease a)
        {
            diseases.Add(a);
        }
    }
    public class Injection:Medicals,IMedicals
    {
        public string form="injection";
        public string placetoinject;

        public Injection() : base(){ form = "injection"; placetoinject = ""; }
        public Injection(string name, int amount, string interchangeability, double price, string producer, string form, double dosage,string placetoinject):base(name,amount,interchangeability,price,producer,dosage)
        {
            this.placetoinject = placetoinject;
        }

        public string Form
        {
            get { return form; }
        }
        public void Modify(int a, double b, double c)
        {
            amount = a;
            price = b;
            dosage = c;
        }
        public void AddDis(Disease a)
        {
            diseases.Add(a);
        }
    }
    public class Salve:Medicals,IMedicals
    {
        public string form="salve";

        public Salve() : base(){ form = "salve"; }
        public Salve(string name, int amount, string interchangeability, double price, string producer, string form, double dosage):base(name,amount,interchangeability,price,producer,dosage)
        {
         
        }
        public string Form
        {
            get { return form; }
        }
        public void Modify(int a, double b, double c)
        {
            amount = a;
            price = b;
            dosage = c;
        }
        public void AddDis(Disease a)
        {
            diseases.Add(a);
        }
    }

    public abstract class Disease
    {
        protected string name;
        protected string symptoms;
        protected string procedures;
        protected string medicals;
        protected List<Medicals> meds;

        public Disease() { name = ""; symptoms = ""; procedures = ""; medicals = ""; }
        public Disease(string name, string symptoms, string procedures, string medicals)
        {
            this.name = name;
            this.symptoms = symptoms;
            this.procedures = procedures;
            this.medicals = medicals;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Symptoms
        {
            set { symptoms = value; }
            get { return symptoms; }
        }
        public string Procedures
        {
            set { procedures = value; }
            get { return procedures; }
        }
        public string Medicals
        {
            set { medicals = value; }
            get { return medicals; }
        }
    }

    public class SimpleDisease : Disease
    {
        public int lvl;

        public SimpleDisease() : base() { lvl = 1; }
        public SimpleDisease(string name, string symptoms, string procedures, string medicals, int lvl) : base(name, symptoms, procedures, medicals)
        {
            this.lvl = lvl;
        }
       
        public int Lvl
        {
            get { return lvl; }
        }

        public void AddMeds(Medicals a)
        {
            meds.Add(a);
        }

    }

    public class HardDIsease : Disease
    {
        public int lvl = 100;

        public HardDIsease() :base(){ lvl = 1; }
        public HardDIsease(string name, string symptoms, string procedures, string medicals, int lvl) : base(name, symptoms, procedures, medicals)
        {
            this.lvl = lvl;
        }
        public int Lvl
        {
            get { return lvl; }
        }
        public void AddMeds(Medicals a)
        {
            meds.Add(a);
        }
    }

    public class Recipy
    {
        public List<Medicals> meds;
        Recipy() { }
    }

    public class Pharmacy
    {
        public string name;
        public string address;
        public List<Medicals> medicals;

        Pharmacy() { name = "Pharmacy"; address = "Address"; }
        Pharmacy(string name,string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        public void GetInfo()
        {

        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
