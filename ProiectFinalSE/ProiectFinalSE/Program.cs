using System;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;

namespace ProiectFinalSE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Form2 childform = new Form2();
        public static Form3 childform_2 = new Form3();
        public static int state = 0;
        public static String[] tempAnswsDaNu = {"Da","Nu" };
        public static String[] tempAnswsBudget = { "Low Budget", "Medium Budget", "All-Inclusive" };
        public static String[] tempAnswsBudget2 = {"Low Budget", "All Inclusive"};
        public static void nextQuestionAndParse(String answer)
        {
            switch (state) {
                case 0:
                    if (answer == "Calda")
                    {
                        
                        childform.setQuestionsAndAnswersOnForm("Va place sa innotati in piscina?", tempAnswsDaNu);
                        state = 1;   
                        break;
                    }

                    if (answer == "Rece")
                    {                  
                        childform.setQuestionsAndAnswersOnForm("Va plac drumetiile?", tempAnswsDaNu);
                        state = 2;
                        break;
                    }

                    if(answer == "Temperata")
                    {
                        childform.setQuestionsAndAnswersOnForm("Va plac City-Break-urile?", tempAnswsDaNu);
                        state = 3;
                        break;
                    }
                    break;
                case 1:
                    if (answer == "Da")
                    {
                        
                        childform.setQuestionsAndAnswersOnForm("Ati prefera un sejur all-inclusive intr-un resort?", tempAnswsDaNu);
                        state = 4;
                        break;
                    }
                    if (answer == "Nu")
                    {
                        String[] tempAnsws1 = { "Mare", "Ocean" };
                        childform.setQuestionsAndAnswersOnForm("Ce ati prefera dintre mare si ocean?", tempAnsws1);
                        state = 5;
                        break;
                    }
                    break;
                case 2:
                    if (answer == "Da")
                    {
                        state = 26;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "Nu")
                    {
                        String[] tempAnsws2 = { "Tara", "Strainatate" };
                        childform.setQuestionsAndAnswersOnForm("Preferati o locatie din tara sau din strainatate?", tempAnsws2);
                        state = 27;
                        break;
                    }
                    break;
                case 3:
                    if (answer == "Da")
                    {     
                        childform.setQuestionsAndAnswersOnForm("Doriti un loc cu multe atractii turistice?", tempAnswsDaNu);
                        state = 30;
                        break;
                    }
                    if (answer == "Nu")
                    {
                        childform.setQuestionsAndAnswersOnForm("Sunteti gurmand?", tempAnswsDaNu);
                        state = 31;
                        break;
                    }
                    break;
                case 4://Ati prefera un sejur all-inclusive intr-un resort?
                    if (answer == "Da")
                    {
                        state = 36;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "NU")
                    {                       
                        state = 37;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 5:
                    if (answer == "Mare")
                    {
                        String[] tempAnsws2 = { "Tara", "Strainatate" };
                        childform.setQuestionsAndAnswersOnForm("Preferati o locatie din tara sau din strainatate?", tempAnsws2);
                        state = 6;
                        break;
                    }
                    if (answer == "Ocean")
                    {                       
                        childform.setQuestionsAndAnswersOnForm("Alegeti o varianta in functie de bugetul dumneavoastra?", tempAnswsBudget);
                        state = 7;
                        break;
                    }
                    break;
                case 6:
                    if (answer == "Tara")
                    {
                        String[] tempAnsws3 = { "Singur", "Cu familia" };
                        childform.setQuestionsAndAnswersOnForm("Ati dori sa mergeti singur sau cu familia?", tempAnsws3);
                        state = 8;
                        break;
                    }
                    if (answer == "Strainatate")
                    {
                        childform.setQuestionsAndAnswersOnForm("Alegeti o varianta in functie de bugetul dumneavoastra?", tempAnswsBudget);
                        state = 9;
                        break;
                    }
                    break;
                case 7:
                    if (answer == "Low Budget")
                    {
                        
                        state = 20;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "Medium Budget")
                    {
                        
                        state = 21;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "All-Inclusive")
                    {
                        
                        state = 22;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 8:
                    if (answer == "Singur")
                    {
                        childform.setQuestionsAndAnswersOnForm("Doriti sa luati si animale de companie cu dumneavoastra?", tempAnswsDaNu);
                        state = 10;
                        break;
                    }
                    if (answer == "Cu familia")
                    {
                        childform.setQuestionsAndAnswersOnForm("Va intereseaza un hotel low budget sau unul cu all inclusive?", tempAnswsBudget2);
                        state = 11;
                        break;
                    }
                    break;
                case 9:
                    if (answer == "Low Budget")
                    {

                        state = 23;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "Medium Budget")
                    {

                        state = 24;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "All-Inclusive")
                    {

                        state = 25;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 10:
                    if (answer == "Da")
                    {
                        childform.setQuestionsAndAnswersOnForm("Va intereseaza un hotel low budget sau unul cu all inclusive?", tempAnswsBudget2);
                        state = 12;
                        break;
                    }
                    if (answer == "Nu")
                    {
                        childform.setQuestionsAndAnswersOnForm("Va intereseaza un hotel low budget sau unul cu all inclusive?", tempAnswsBudget2);
                        state = 13;
                        break;
                    }
                    break;
                case 11:
                    if (answer == "Low Budget")
                    {
                        
                        state = 18;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "All Inclusive")
                    {
                        
                        state = 19;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 12:
                    if (answer == "Low Budget")
                    {   
                        state = 14;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "All Inclusive")
                    {     
                        state = 15;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 13:
                    if (answer == "Low Budget")
                    {
                        state = 16;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "All Inclusive")
                    {
                        state = 17;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 14:
                    getDestFromDbAndShow("voila_mamaia");
                    break;
                case 15:
                    getDestFromDbAndShow("hotel_amiral_mamaia");           
                    break;
                case 16:
                    getDestFromDbAndShow("hostel_nova_route");
                    break;
                case 17:
                    getDestFromDbAndShow("hotel_amiral_mamaia");
                    break;
                case 18:
                    getDestFromDbAndShow("hotel_pinguin");
                    break;
                case 19:
                    getDestFromDbAndShow("mera_onix");
                    break;
                case 20:
                    getDestFromDbAndShow("hotel_petunia)");
                    break;
                case 21:
                    getDestFromDbAndShow("inside_melia_palma");
                    break;
                case 22:
                    getDestFromDbAndShow("novotel_phuket");
                    break;
                case 23:
                    getDestFromDbAndShow("pao_de_acucar");
                    break;
                case 24:
                    getDestFromDbAndShow("bintana_sa_paraiso");
                    break;
                case 25:
                    getDestFromDbAndShow("angra_marina");
                    break;
                case 26:
                    getDestFromDbAndShow("sfinxul_platoul_bucegi");
                    break;
                case 27:
                    if (answer == "Tara")
                    {
                        state = 28;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "Strainatate")
                    {
                        state = 29;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 28:
                    getDestFromDbAndShow("sinaia_view");
                    break;
                case 29:
                    getDestFromDbAndShow("relais_chateaux");
                    break;
                case 30:
                    if (answer == "Da")
                    {

                        state = 31;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "Nu")
                    {
                        state = 32;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 31:
                    getDestFromDbAndShow("britannique");
                    break;
                case 32:
                    getDestFromDbAndShow("hotel_du_leman");
                    break;
                case 33:
                    if (answer == "Da")
                    {

                        state = 34;
                        nextQuestionAndParse("");
                        break;
                    }
                    if (answer == "Nu")
                    {

                        state = 35;
                        nextQuestionAndParse("");
                        break;
                    }
                    break;
                case 34:
                    getDestFromDbAndShow("aman_venice");
                    break;
                case 35:
                    getDestFromDbAndShow("hotel_fontana");
                    break;
                case 36:
                    getDestFromDbAndShow("sunrise_aqua_joy");
                    break;
                case 37:
                    getDestFromDbAndShow("hotel_flora_mamaia");
                    break;
            }
        }
        
        public static void getDestFromDbAndShow(String localization_key)
        {
            string destinationFromDb = "";
            string baza = "Destinations.accdb";
            string fullpath = Path.GetFullPath(baza);
            string prov = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ";
            string stringdeconectare = prov + fullpath;
            OleDbConnection cnn = new OleDbConnection(stringdeconectare);
            cnn.Open();

            //OleDbCommand getQuestion = new OleDbCommand("SELECT * FROM Destinations WHERE Localization_key=" + localization_key, cnn);
            //Select * FROM destionation WHERE localization_key LIKE "% + localization_key + %"   + localization_key +

            OleDbCommand getQuestion = new OleDbCommand("Select Location FROM Destinations WHERE Localization_key LIKE '%" + localization_key + "%'", cnn);
            OleDbDataReader reader = getQuestion.ExecuteReader();
            while (reader.Read())
            {
                destinationFromDb = reader[0].ToString();
            }
            //MessageBoxButtons buttons = MessageBoxButtons.OK;
            //DialogResult zeroItemsCheked = MessageBox.Show(destinationFromDb, "INFO", buttons);


            childform_2.showDestination(localization_key, destinationFromDb);

            cnn.Close();
        }
            
    }
}
