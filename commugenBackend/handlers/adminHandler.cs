 using MockData; 
using System.Text.Json;

public static class AdminHandler
{

    public static string AddForm()
    {
        FormMockData.Forms.Add(new Form 
        {
            FormID = 10,
            CreatorUserID = 999,
            Name = "New Placeholder Form"
        });
        return "we are adding an item";
    }


    public static string ReturnForm(int formID)
    {
        var form = FormMockData.Forms.FirstOrDefault(f => f.FormID == formID);
        
        return form != null ? JsonSerializer.Serialize(form) : "Form not found";
    }

    public static string ReturnForms()
    {
            string temp = "";
            foreach (var obj in FormMockData.Forms)
            {
                temp+=obj.Name;
            } 

            return temp;
    }

    public static void RemoveForm(int i)
    {
        FormMockData.Forms.RemoveAt(i); 
    }

    public static string AddField()
    {
        return "this is admin router from function";
    }
    

    public static string ChangeField()
    {
        return "this is admin router from function";
    }
    
    public static string RemoveField()
    {
        return "this is admin router from function";
    }


}