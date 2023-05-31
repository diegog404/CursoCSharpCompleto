using revisao_listas_01;

Console.Write("How many patients will be registered?" );
int n = int.Parse(Console.ReadLine());

List<Patient> patients = new List<Patient>(n);

for(int i = 0;i <= n; i++)
{
    Console.WriteLine("Patient #" + i + ":");
    int id = int.Parse(Console.ReadLine());

    string name = Console.ReadLine();

    string employment = Console.ReadLine();

    patients.Add(new Patient(id, name, employment));
}

Console.Write("Enter the patient id that will be changed: ");
int searchId = int.Parse(Console.ReadLine());

Patient search = patients.(x => x.Id == searchId);
