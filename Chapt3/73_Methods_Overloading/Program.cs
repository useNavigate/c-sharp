var medicalAppointment = new MedicalAppointment(
    "John Smith");

//simply reschedule
medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

var sara = new MedicalAppointment("sara ryu");
Console.ReadKey();


class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on " + medicalAppointment.GetDate()
            ) ;
    }
}
class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    //public MedicalAppointment(string patientName, DateTime date)
    //{
    //    _patientName = patientName;
    //    _date = date;
    //}


    public MedicalAppointment(string patientName = "Unknown", int daysFromNow =7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }




    public DateTime GetDate() => _date;


    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd
            );
    }
}