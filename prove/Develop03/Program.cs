using System;

class Scripture
{
    private string scripturetext;
     private Reference scriptureReference;

        public Scripture (Reference _scriptureReference, string _scriptureText)   
        {
            scriptureReference  = _scriptureReference;
            scripturetext       = _scriptureText;
            
        }

        public string toString()
        {
            return string.Format("{0}",scriptureText);
        }
}