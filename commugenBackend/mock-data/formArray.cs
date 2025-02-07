namespace MockData
{
    public class Form
    {
        private static int nextFormID = 1;


        public int formID { get; set; }
        public int creatorUserID { get; set; }
        public string name { get; set; }

        public Form(int creatorUserID,string name){
                this.formID = nextFormID++;
                this.creatorUserID = creatorUserID;
                this.name = name;
        }   
    }


    public class Field
    {
        private static int nextFieldID = 1;

        public int fieldID { get; private set; }
        public int formID { get; set; }
        public string type { get; set; }
        public string name { get; set; }

        public Field(string type, string name, int formID)
        {
            this.fieldID = nextFieldID++;
            this.name = name;
            this.type = type;
            this.formID = formID;
        }
    }

    public static class FieldMockData
    {
        public static List<Field> Fields = new List<Field>{};
    }


    public static class FormMockData
    {
        public static List<Form> Forms = new List<Form>{};
    }
}
