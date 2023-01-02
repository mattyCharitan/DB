using ClinicManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task<List<Patient>> GetAllPatients()
        {
            using (var db = new ClinicContext())
            {
                return await db.Patients.ToListAsync();
            }
        }


        private async void AddPatient()
        {
            using (var db = new ClinicContext())
            {
                var patient = new Patient
                {
                    FirstName = "אברהם",
                    LastName = "כהן",
                    Id = "123456789",
                    BirthDate = DateTime.Now,
                    Address = await CreateAddress("חיפה", "צהל",41, "א",7), 
                    MobileNumber = "0541234567"
                };
                 db.Patients.Add(patient);
                await db.SaveChangesAsync();
            }
        }

        private async Task<Address> CreateAddress(string cityName, string streetName, int hNum, string entrance, int aNum)
        {
            Address address;
            using (var db = new ClinicContext())
            {
                City city = await db.Cities.FirstOrDefaultAsync(c => c.Name == cityName);
                if (city == null)
                {
                    city = new City
                    {
                        Name = cityName
                    };
                    db.Cities.Add(city);
                    await db.SaveChangesAsync();
                }

                Street street = await db.Streets.FirstOrDefaultAsync(s => s.Name == streetName && s.City.Name == city.Name);
                if (street == null)
                {
                    street = new Street
                    {
                        Name = streetName,
                        CityId = city.Id
                    };
                    db.Streets.Add(street);
                    await db.SaveChangesAsync();
                }

                address = await db.Addresses.FirstOrDefaultAsync(a => a.Street.Name == streetName && a.Street.City.Name == city.Name && a.Entrance == entrance && a.HouseNumber == hNum && a.AppartmentNum == aNum);

                if (address == null)
                {
                    address = new Address
                    {
                        StreetId = street.Id,
                        HouseNumber = hNum,
                        Entrance = entrance,
                        AppartmentNum = aNum
                    };
                    db.Addresses.Add(address);
                    await db.SaveChangesAsync();
                }
            }
            return address;
        }
        


        private async void UpdatePatient(string id, string firstName, string lastName)
        {
            using (var db = new ClinicContext())
            {
                var patient = await db.Patients.FirstOrDefaultAsync(p => p.Id == id);
                if (patient != null)
                {
                    patient.FirstName = firstName;
                    patient.LastName = lastName;
                   
                    await db.SaveChangesAsync();
                }
            }
        }

        private async void RemovePatient(string id)
        {
            using (var db = new ClinicContext())
            {
                var patient = await db.Patients.FirstOrDefaultAsync(p => p.Id == id);
                if (patient != null)
                {
                    db.Patients.Remove(patient);
                    await db.SaveChangesAsync();
                }
            }
        }

        private void GetAllPatientsBtn_Click(object sender, EventArgs e)
        {
            Task<List<Patient>> patients = GetAllPatients();
            patients.Wait();
            foreach (Patient p in patients)
            {
                MessageBox.Show($"Id: {p.Id} First name: {p.FirstName} Last name: {p.LastName}");
            }          
        }

        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            AddPatient();

        }

        private void UpdatePatientBtn_Click(object sender, EventArgs e)
        {
            UpdatePatient("123456789", "יעקב", "לוי");
        }

        private void RemovePatientBtn_Click(object sender, EventArgs e)
        {
            RemovePatient("123456789");
        }

        private void newGetAllPatients()
        {
            using (var db = new ClinicContext())
            {
                var allPatients = db.Patients
                    .Include(p => p.Address)
                    .ThenInclude(a => a.Street)
                    .ThenInclude(s => s.City).ToList();
                display(allPatients);
            }

            

        }

        private void display(List<Patient> patients)
        {
            foreach (Patient p in patients)
            {
                if(p.Address != null) {
                    MessageBox.Show($"First name: {p.FirstName} Last name: {p.LastName} City: {p.Address.Street.City.Name} Street:{p.Address.Street.Name} Number: {p.Address.HouseNumber}");
                }

                else
                {
                    MessageBox.Show($"First name: {p.FirstName} Last name: {p.LastName}");

                }
            }

        }

        private void NewGetAllBtn_Click(object sender, EventArgs e)
        {
            newGetAllPatients();
        }
    }
}