namespace PresidentChecker
{
    public class Checker
    {
        public static bool check(int age, int residency, int terms, bool rebel, bool natural) {
            return (age >= 35 && residency >= 14 && terms < 2 && natural && !rebel);
        }
    }
}