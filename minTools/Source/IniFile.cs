using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace minTools
{
    namespace Config
    {
        public class IniFile
        {
            Dictionary<string, string> container;
            bool loaded;

            public IniFile(string filename)
            {
                loaded = false;

                if (!File.Exists(filename))
                    return; //file not found

                container = new Dictionary<string, string>();

                if (!parse(File.ReadAllText(filename)))
                    return;

                loaded = true;
            }

            public bool isLoaded()
            {
                return loaded;
            }

            public bool doesKeyExist(string key)
            {
                if (!loaded)
                    return false;

                return container.ContainsKey(key);
            }

            public string getKeyValue(string key)
            {
                if (doesKeyExist(key))
                    return container[key];
                return "";
            }

            public bool addKeyValue(string key, string value)
            {
                if (doesKeyExist(key))
                    return false;
                container.Add(key, value);
                return true;
            }

            bool parse(string input)
            {
                List<string> tokens = makeTokens(input);
                string key = "", value = "";

                //while there are tokens left to parse
                while (tokens.Count > 0)
                {
                    string thisToken = tokens[0];

                    if(thisToken.Equals("="))
                    {
                        //started on equals/no key specified, error
                        return false;
                    }
                    else 
                    {
                        parse_keyValuePair(ref tokens);
                    }
                }

                //all tokens parsed, no errors
                return true;
            }

            bool parse_keyValuePair(ref List<string> tokens)
            {
                //get key
                string value, key = tokens[0]; 
                tokens.RemoveAt(0);

                //get equals sign
                if (tokens.Count == 0)
                    return false; //error, expected =
                else if (!tokens[0].Equals("="))
                    return false; //error, expected =
                else
                    tokens.RemoveAt(0);

                //get value
                if (tokens.Count == 0)
                    return false; //error, expected value
                else
                    value = tokens[0];

                //save
                container.Add(key, value);
                tokens.RemoveAt(0);

                return true;
            }

            List<string> makeTokens(string input)
            {
                int index = 0;
                string buffer = "";
                bool areWeLexingString = false;

                List<string> tokens = new List<string>();

                while (index < input.Length)
                {
                    string thisChar = input[index].ToString();

                    if(thisChar.Equals("\""))
                    {
                        if(areWeLexingString)
                        {
                            //add buffer even if empty
                            tokens.Add(buffer);
                            buffer = "";
                            areWeLexingString = false;
                        }
                        else
                        {
                            if (!string.IsNullOrWhiteSpace(buffer))
                                tokens.Add(buffer);
                            buffer = "";
                            areWeLexingString = true;
                        }
                    }
                    else if (areWeLexingString)
                    {
                        buffer += thisChar;
                    }
                    else if (!areWeLexingString && string.IsNullOrWhiteSpace(thisChar))
                    {
                        if(!buffer.Equals(string.Empty))
                            tokens.Add(buffer);
                        buffer = "";
                    }
                    else if(thisChar.Equals("="))
                    {
                        if (!buffer.Equals(string.Empty))
                            tokens.Add(buffer);
                        tokens.Add("=");
                        buffer = "";
                    }
                    else
                        buffer += thisChar;

                    ++index;
                }

                if (areWeLexingString)
                    return tokens; //error, unclosed string literal

                if (!buffer.Trim().Equals(string.Empty))
                    tokens.Add(buffer);

                return tokens;
            }

        }
    }
}
