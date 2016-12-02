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
using WpfApplication1;

namespace WpfApplication2
{
    //public static class Admin
    //{
    //   static Medicals pill = new Pills();
    //   static Medicals inject = new Injection();
    //   static Medicals salve = new Salve();
    //    public static void set_pill(string name, int amount, string interchangeability, double price, string producer, string form, double dosage)
    //    {
    //        pill.Name = name;
    //        pill.Amount = amount;
    //        pill.Interchangeability = interchangeability;
    //        pill.Price = price;
    //        pill.Producer = producer;
    //        pill.Dosage = dosage;
    //    }
    //    public static string get_inject()
    //    {
    //        return pill.Name + pill.Amount + pill.Interchangeability + pill.Price + pill.Producer + "pills" + pill.Dosage;
    //    }
    //    public static void set_injcet(string name, int amount, string interchangeability, double price, string producer, string form, double dosage)
    //    {
    //        inject.Name = name;
    //        inject.Amount = amount;
    //        inject.Interchangeability = interchangeability;
    //        inject.Price = price;
    //        inject.Producer = producer;
    //        inject.Dosage = dosage;
    //        inject.Placetoinject;
    //    }
    //    public static string get_pill()
    //    {
    //        return pill.Name + pill.Amount + pill.Interchangeability + pill.Price + pill.Producer + "pills" + pill.Dosage;
    //    }
    //}
    public class AdminPill
    {

        public Pills AddPill(string name, int amount, string interchangeability, double price, string producer, string form, double dosage)
        {
            Pills pill = new Pills();
            pill.Name = name;
            pill.Amount = amount;
            pill.Interchangeability = interchangeability;
            pill.Price = price;
            pill.Producer = producer;
            pill.Dosage = dosage;
            return pill;
        }
        public Pills ModifyPill(Pills pill, string name, int amount, string interchangeability, double price, string producer, string form, double dosage)
        {
            pill.Name = name;
            pill.Amount = amount;
            pill.Interchangeability = interchangeability;
            pill.Price = price;
            pill.Producer = producer;
            pill.Dosage = dosage;
            return pill;
        }
        public void ShowPillInfo(Pills pill)
        {
            MessageBox.Show(Convert.ToString(pill.Name + "\n" + pill.Amount + "\n" + pill.Interchangeability + "\n" + pill.Price + "\n" + pill.Producer + "\n" + pill.Form + "\n" + pill.Dosage));

        }
    }
    public class AdminInject
    {
        public Injection AddInjection(string name, int amount, string interchangeability, double price, string producer, string form, double dosage, string placetoinject)
        {
            Injection inject = new Injection();
            inject.Name = name;
            inject.Amount = amount;
            inject.Interchangeability = interchangeability;
            inject.Price = price;
            inject.Producer = producer;
            inject.Dosage = dosage;
            inject.Placetoinject = placetoinject;
            return inject;
        }

        public Injection ModifyInjection(Injection inject, string name, int amount, string interchangeability, double price, string producer, string form, double dosage, string placetoinject)
        {
            inject.Name = name;
            inject.Amount = amount;
            inject.Interchangeability = interchangeability;
            inject.Price = price;
            inject.Producer = producer;
            inject.Dosage = dosage;
            inject.Placetoinject = placetoinject;
            return inject;
        }
        public void ShowInjectionInfo(Injection inject)
        {

            MessageBox.Show(Convert.ToString(inject.Name + "\n" + inject.Amount + "\n" + inject.Interchangeability + "\n" + inject.Price + "\n" + inject.Producer + "\n" + inject.Form + "\n" + inject));
        }
    }
    public class AdminSalve
    {
        public Salve AddSalve(string name, int amount, string interchangeability, double price, string producer, string form, double dosage)
        {
            Salve salve = new Salve();
            salve.Name = name;
            salve.Amount = amount;
            salve.Interchangeability = interchangeability;
            salve.Price = price;
            salve.Producer = producer;
            salve.Dosage = dosage;
            return salve;
        }

        public Salve ModifySalve(Salve salve, string name, int amount, string interchangeability, double price, string producer, string form, double dosage)
        {
            salve.Name = name;
            salve.Amount = amount;
            salve.Interchangeability = interchangeability;
            salve.Price = price;
            salve.Producer = producer;
            salve.Dosage = dosage;
            return salve;
        }
        public void ShowSalveInfo(Salve salve)
        {
            MessageBox.Show(Convert.ToString(salve.Name + "\n" + salve.Amount + "\n" + salve.Interchangeability + "\n" + salve.Price + "\n" + salve.Producer + "\n" + salve.Form + "\n" + salve));
        }
    }
    public class AdminSimpleDisease
    {
        public SimpleDisease AddSimpleDisease(string name, string symptoms, string procedures, string medicals)
        {
            SimpleDisease sd = new SimpleDisease();
            sd.Name = name;
            sd.Symptoms = symptoms;
            sd.Procedures = procedures;
            sd.Medicals = medicals;
            sd.Lvl = 1;
            return sd;
        }

        public SimpleDisease ModifySimpleDisease(SimpleDisease sd, string name, string symptoms, string procedures, string medicals)
        {
            sd.Name = name;
            sd.Symptoms = symptoms;
            sd.Procedures = procedures;
            sd.Medicals = medicals;
            sd.Lvl = 1;
            return sd;
        }
        public void ShowSimpleDiseaseInfo(SimpleDisease sd)
        {
            MessageBox.Show(Convert.ToString(sd.Name + "\n" + sd.Symptoms + "\n" + sd.Procedures + "\n" + sd.Medicals + "\n"));
        }
    }
    public class AdminHardDisease
    {
        public HardDisease AddHardDisease(string name, string symptoms, string procedures, string medicals)
        {
            HardDisease hd = new HardDisease();
            hd.Name = name;
            hd.Symptoms = symptoms;
            hd.Procedures = procedures;
            hd.Medicals = medicals;
            hd.Lvl = 100;
            return hd;
        }

        public HardDisease ModifyHardDisease(HardDisease hd, string name, string symptoms, string procedures, string medicals)
        {
            hd.Name = name;
            hd.Symptoms = symptoms;
            hd.Procedures = procedures;
            hd.Medicals = medicals;
            hd.Lvl = 100;
            return hd;
        }
        public void ShowHardDiseaseInfo(HardDisease hd)
        {
            MessageBox.Show(Convert.ToString(hd.Name + "\n" + hd.Symptoms + "\n" + hd.Procedures + "\n" + hd.Medicals + "\n"));
        }
    }


}



public class UserPill
{

    public void ShowPillInfo(Pills pill)
    {
        MessageBox.Show(Convert.ToString(pill.Name + "/n" + pill.Amount + "/n" + pill.Interchangeability + "/n" + pill.Price + "/n" + pill.Producer + "/n" + pill.Form + "/n" + pill.Dosage));

    }
}
public class UserInject
{
    public void ShowInjectionInfo(Injection inject)
    {

        MessageBox.Show(Convert.ToString(inject.Name + "/n" + inject.Amount + "/n" + inject.Interchangeability + "/n" + inject.Price + "/n" + inject.Producer + "/n" + inject.Form + "/n" + inject));
    }
}
public class UserSalve
{
    public void ShowSalveInfo(Salve salve)
    {
        MessageBox.Show(Convert.ToString(salve.Name + "/n" + salve.Amount + "/n" + salve.Interchangeability + "/n" + salve.Price + "/n" + salve.Producer + "/n" + salve.Form + "/n" + salve));
    }
}
public class UserSimpleDisease
{
    public void ShowSimpleDiseaseInfo(SimpleDisease sd)
    {
        MessageBox.Show(Convert.ToString(sd.Name + "/n" + sd.Symptoms + "/n" + sd.Procedures + "/n" + sd.Medicals + "/n"));
    }
}
public class UserHardDisease
{
    public void ShowHardDiseaseInfo(HardDisease hd)
    {
        MessageBox.Show(Convert.ToString(hd.Name + "/n" + hd.Symptoms + "/n" + hd.Procedures + "/n" + hd.Medicals + "/n"));
    }
}


