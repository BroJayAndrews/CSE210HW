using System;

class ScriptureMemorizer
{
    private Scripture scripture;

    private List<string> scriptureTextList;

    public SrirptureMemorizer(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList = new List<string>();
        convertTextToList();
    }
        private void convertTextToList()
    {
            scriptureTextList = scripture.toString().Split('').ToList();

    }
        
    }
    