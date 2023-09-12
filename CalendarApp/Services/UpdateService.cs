using CalendarApp.Entities;

namespace CalendarApp.Services
{
    public delegate void UpdateEventHandler();
    public class UpdateService
    {
        public event UpdateEventHandler Update;

        public DailyHours? _dailyHours;

        public bool _hoursInitialized = false;

        public void ChangeHours(DailyHours dailyHours)
        {
            _dailyHours = dailyHours;

            Console.WriteLine("UPDATED HOURS");

            Update.Invoke();
        }

        public void hoursInitialized()
        {
            _hoursInitialized = true;
        }
    }
}
