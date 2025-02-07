namespace MockData
{
    public class Form
    {
        public int FormID { get; set; }
        public int CreatorUserID { get; set; }
        public string Name { get; set; }
    }

    // public class Field
    // {
    //     public int FormID { get; set; }
    //     public int CreatorUserID { get; set; }
    //     public string Name { get; set; }
    // }


    public static class FormMockData
    {
        // public static Form[] Forms = new Form[]
        // {
        //     new Form { FormID = 1, CreatorUserID = 101, Name = "Survey Form" },
        //     new Form { FormID = 2, CreatorUserID = 102, Name = "Feedback Form" },
        //     new Form { FormID = 3, CreatorUserID = 103, Name = "Registration Form" }
        // };


        public static List<Form> Forms = new List<Form>
        {
            new Form { FormID = 1, CreatorUserID = 101, Name = "Survey Form" },
            new Form { FormID = 2, CreatorUserID = 102, Name = "Feedback Form" },
            new Form { FormID = 3, CreatorUserID = 103, Name = "Registration Form" }
        };






    }
}
