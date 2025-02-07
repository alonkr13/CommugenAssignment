using MockData; 
using System.Text.Json;

public static class UserHandler
{

    public static string AddField(string type, string name, int formID)
    {
        Field newField = new Field(type,name,formID);
        
         FieldMockData.Fields.Add(newField);
        return "we are adding an item"; 
    }

    public static string GetFields()
    {
        return JsonSerializer.Serialize(FieldMockData.Fields);
    }


    public static string GetField(int fieldID)
    {
        int fieldIndex = FieldMockData.Fields.FindIndex(f => f.fieldID == fieldID);
        return JsonSerializer.Serialize(FieldMockData.Fields[fieldIndex]);
    }

                         
    public static void ChangeField(int fieldID, string name)
    {
        int fieldIndex = FieldMockData.Fields.FindIndex(f => f.fieldID == fieldID);
        FieldMockData.Fields[fieldIndex].name = name;
    }
    
    public static string RemoveField(int fieldID)
    {
        int fieldIndex = FieldMockData.Fields.FindIndex(f => f.fieldID == fieldID);
        if (fieldIndex == -1)
        {
            throw new Exception($"Field with ID {fieldID} not found.");
        }

        FieldMockData.Fields.RemoveAt(fieldIndex);
        return "removed successfully";
    }

}