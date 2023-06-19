class Customer : Person
{
    
    public const string Solve = "Sick list from 12.05 - 30.06"; 
public string MiddleName;
public string DistrictHospital;
public string Disease;
public Customer (string name ,string surname, string middleName, int yearOfBirth ,string districtHospital,
string disease)
: base(name, surname, yearOfBirth)
{
    MiddleName = middleName;
    DistrictHospital = districtHospital;
    Disease = disease;

}

public override string Info()
{
    var years = DateTime.Now.Year - YearOfBirth;
 return $"{Name} {Surname} {MiddleName} is {years} her district hospital - {DistrictHospital}, disease - {Disease}";
}


public override void SolveProblem()
{

Console.WriteLine(Solve);
}


}