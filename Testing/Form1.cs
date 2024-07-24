using System.Windows.Forms;
using static Testing.Service.Service;
using static Testing.Model.DateModel;
using Testing.Model;
using System.Security.Cryptography.X509Certificates;
namespace Testing
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();

            }

        public string Days()
            {
            string day;
            switch (DayBox.Text)
                {
                case "ראשון":
                    day = "באחד בשבת"; break;
                case "שני":
                    day = "בשני "; break;

                case "שלישי":
                    day = "בשלישי "; break;
                case "רביעי":
                    day = "רביעי "; break;
                case "חמישי":
                    day = "בחמישי "; break;
                case "שישי":
                    day = "בששי "; break;
                default:
                    day = "";
                    break;
                }
            return $"{day} בשבת";
            }
        public string DayMonth()
            {
            int Days;
            int.TryParse(DayMonthBox.Text, out Days);
            Dictionary<int, string> DayMonth = new()
                {

                    {1,"יום אחד" },
                    {2,"שני ימים" },
                    {3,"שלשה ימים" },
                    {4,"ארבעה ימים" },
                    {5,"חמישה ימים" },


                };

            return $"{DayMonth[Days]} לירח";

            }
        public string Month()
            {
            string DAEY = DayMonthBox.Text;
            int Days;
            switch (MonthBox.Text)
                {
                case "תשרי":
                    Days = 1; break;
                case "חשוון":
                    Days = 2; break; ;

                case "כסליו":
                    Days = 3; break;
                case "טבת":
                    Days = 4; break;
                case "שבט":
                    Days = 5; break;
                case "אדר ראשון":
                    Days = 6; break;
                case "אדר שני":
                    Days = 7; break;
                default:
                    Days = 0;
                    break;
                }

            Dictionary<int, string> Month = new()
                {
                    {1,"תשרי" },
                    {2,"חשוון" },
                    {3,"כסליו" },
                    {4,"טבת" },
                    {5,"שבט" },
                    {6,"אדר ראשון" },
                    {7,"אדר שני" },
                    {8,"ניסן" },
                    {9,"אייר" },
                    {10,"סיוון" },
                    {11,"תמוז" },
                    {12,"אב" },
                    {13,"אלול" },

                };
            if (DAEY == "30")//חישוב השלושים לחודש שהוא ראש חודש הבא
                {
                if (Days < 13)
                    {
                    Days++;
                    }
                Days = 1;
                }
            return $"{Month[Days]}";


            }
        public string Years()
            {
            string years = YearBox.Text;
            string convertToAlfabate;
            switch (years)
                {
                case @"תשפ""ד":
                    convertToAlfabate = "חמשת אלפים ושבע מאות ושמנים וארבע";
                    break;
                case @"תשפ""ה":
                    convertToAlfabate = "חמשת אלפים ושמונה מאות וחמישה";
                    break;
                case @"תשפ""ו":
                    convertToAlfabate = "חמשת אלפים ושמונה מאות וששה";
                    break;
                default:
                    convertToAlfabate = "";
                    break;
                }
            return convertToAlfabate;




            }
        public string ResultDate()
            {
            MessageBox.Show($"{Days()} {DayMonth()} {Month()} {Years()} לבריאת העולם");
            return $"{Days()} {DayMonth()} {Month()} {Years()} לבריאת העולם";
            }
        public void CreateNewModelDate(object sender, EventArgs e)
            {
            string resultDate = ResultDate();
            DateModel NawDate = new(
                 Day: DayBox.Text, DayMonth: DayMonthBox.Text, Month: MonthBox.Text, Year: YearBox.Text, Result: resultDate);
            AddElementService(NawDate);

            }


        }

    }


