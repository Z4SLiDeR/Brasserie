using Brasserie.Model;
using Brasserie.Model.Restaurant.Design;
using Brasserie.Model.Restaurant.People;
using System.Diagnostics.Metrics;
using static Brasserie.Model.Restaurant.People.Customer;
using static System.Net.Mime.MediaTypeNames;

namespace Brasserie.View
{
    public partial class MainPage : ContentPage
    {
        Counter myCounter;
        public MainPage()
        {
            InitializeComponent();
            myCounter = new Counter();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            myCounter.IncrementCounter();
            EntryCount.Text = myCounter.CounterValue.ToString();
            CounterBtn.Text = "Nombre de clique" + myCounter.CounterValue.ToString();
        }

        private void buttonTestCreateFirstPersons_Clicked(object sender, EventArgs e)
        {
            Person firstPerson = new Person(id: 1, lastName: "Beumier", firstName: "Damien",
            gender: true, email: "dambeumier@gmail.com", mobilePhoneNumber: "0489142293");
            Person secondPerson = new Person(id: 2, lastName: "Deroisin", firstName: "Sophie",
            gender: false, email: "sophiederoisin@gmail.com", mobilePhoneNumber: "0473121314");
            Person ThirdPerson = new Person(3, "Jandrin", "Marc", true, "jandrinmarc@gmail.com",
            mobilePhoneNumber: "0485556678");
            Person FourthPerson = new Person(4, "Lupant", "Sebastien");
            Person FifthPerson = new Person();
            //Person TestPerson = new Person( lastName: "Lupant", firstName: "Sebastien");


        }

        private void buttonTestEncapsulation_Clicked(object sender, EventArgs e)
        {
            Person p = new Person(id: 2, lastName: "Deroisin", firstName: "Sophie", gender:
            false, email: "sophiederoisin@gmail.com", mobilePhoneNumber: "0473121314");

            p.FirstName = "Marie-Sophie";
            lblDebug.Text = p.FirstName;
        }

        private void buttonTestStatic_Clicked(object sender, EventArgs e)
        {
            string mail = "mon mail@gmail.com";
            bool testMail = Person.CheckEMail(mail);
            lblDebuga.Text = $"Nombre d'instance de classe Person : {Person.TotalPersons}";
            
        }

        private void TestNewTable(object sender, EventArgs e)
        {
            Table t = new Table(1, 2, false);
            lblDebugar.Text = $"Nombre de siège : {Table.TotalSeats}";
        }


        private void buttonTestInheritance_Clicked(object sender, EventArgs e)
        {
            Customer c = new Customer(7, "Maggi", "Francesca", false,"francesca190@gmail.com", "0475689034", CustomerType.New);

            StaffMember staffm = new StaffMember(8, "Dries", "François", true,
           "francoisdries@gmail.com", "0485113289", "BE83 2378 9876 2390", "4, rue du marais 7030Ghlin", 3275.0);
           
            Manager m = new Manager(9, "Duchief", "Marc", true, "duchiefmarc@gmail.com","0491203040", "BE84 1128 9836 3518", "2, rue du pont 7000 Mons", 5200.5, "Password01");

        }
    }

}
