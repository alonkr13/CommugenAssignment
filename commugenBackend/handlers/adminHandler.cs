using MockData; 
using System.Text.Json;

public static class AdminHandler
{

    public static void AddForm(int creatorUserID,string name)
    {
        Form newForm = new Form(creatorUserID,name);
         FormMockData.Forms.Add(newForm);
    }


    public static string GetForm(int formID)
    {
        var form = FormMockData.Forms.FirstOrDefault(f => f.formID == formID);
        return form != null ? JsonSerializer.Serialize(form) : "Form not found";
    }

    public static string GetForms()
    {
        return JsonSerializer.Serialize(FormMockData.Forms);
    }

    public static void RemoveForm(int formID)
    {
        int formIndex = FormMockData.Forms.FindIndex(f => f.formID == formID);
        FormMockData.Forms.RemoveAt(formIndex); 
    }


}