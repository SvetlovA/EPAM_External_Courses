using System.Text;

namespace Task4
{
    /// <summary>
    /// Class MyString
    /// </summary>
    public class MyString
    {
        private char[] _charString;

        /// <summary>
        /// Constructor of class MyString
        /// </summary>
        /// <param name="parInputChar"> Input array of char</param>
        public MyString(char[] parInputChar)
        {
            _charString = parInputChar;
        }

        /// <summary>
        /// Cnstructor of class MyString
        /// </summary>
        /// <param name="parInputString"> Input string</param>
        public MyString(string parInputString)
        {
            _charString = parInputString.ToCharArray();
        }

        /// <summary>
        /// Constructor of class MyString
        /// </summary>
        /// <param name="parSize"> Size of array</param>
        private MyString(int parSize)
        {
            _charString = new char[parSize];
        }

        /// <summary>
        /// Concatinating of strings
        /// </summary>
        /// <param name="parStr1"> Input string</param>
        /// <param name="parStr2"> Input string</param>
        /// <returns> Concatination string</returns>
        public static MyString operator +(MyString parStr1, MyString parStr2)
        {
            MyString output = new MyString(parStr1._charString.Length + parStr2._charString.Length);
            for (int i = 0, j = 0; i < output._charString.Length; i++)
            {
                if (i < parStr1._charString.Length)
                {
                    output._charString[i] = parStr1._charString[i];
                }
                else
                {
                    output._charString[i] = parStr2._charString[j];
                    j++;
                }
            }
            return output; 
        }

        /// <summary>
        /// Deleting substring from string
        /// </summary>
        /// <param name="parStr1"> Input string</param>
        /// <param name="parStr2"> Input string</param>
        /// <returns> Deleted string</returns>
        public static MyString operator -(MyString parStr1, MyString parStr2)
        {
            MyString output = new MyString(parStr1._charString.Length);
            int i = 0;
            while (i < parStr1._charString.Length)
            {
                if (parStr1._charString[i] == parStr2._charString[0])
                {
                    if (Matching(parStr1._charString, parStr2._charString, i))
                    {
                        int p = i;
                        int g = i;
                        for (int l = i + parStr2._charString.Length; l < parStr1._charString.Length; l++)
                        {
                            output._charString[p++] = parStr1._charString[l];
                        }
                        for (int k = i + parStr2._charString.Length; k < parStr1._charString.Length; k++)
                        {
                            parStr1._charString[g++] = parStr1._charString[k];
                        }
                        for (int a = g; a < parStr1._charString.Length; a++)
                        {
                            parStr1._charString[a] = '\0';
                        }
                    }
                    else
                    {
                        output._charString[i] = parStr1._charString[i];
                        i++;
                    }
                }
                else
                {
                    output._charString[i] = parStr1._charString[i];
                    i++;
                }
            }
            return output;
        }

        /// <summary>
        /// Chek for matches
        /// </summary>
        /// <param name="i"> Index of start position</param>
        /// <param name="Str1"> First string</param>
        /// <param name="Str2"> Substring</param>
        /// <returns> Match or not match</returns>
        private static bool Matching(char[] Str1, char[] Str2, int i)
        {
            for (int j = 0; j < Str2.Length; j++)
            {
                if (Str1[i + j] != Str2[j])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Comparing strings
        /// </summary>
        /// <param name="parStr1"> Input string</param>
        /// <param name="parStr2"> Input string</param>
        /// <returns> Equal or not equal</returns>
        public static bool operator !=(MyString parStr1, MyString parStr2)
        {
            if (parStr1._charString.Length == parStr2._charString.Length)
            {
                for (int i = 0, j = 0; i < parStr1._charString.Length; i++, j++)
                {
                    if (parStr1._charString[i] != parStr2._charString[j])
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Comparing strings
        /// </summary>
        /// <param name="parStr1"> Input string</param>
        /// <param name="parStr2"> Input string</param>
        /// <returns> Equal or not equal</returns>
        public static bool operator ==(MyString parStr1, MyString parStr2)
        {
            if (parStr1._charString.Length == parStr2._charString.Length)
            {
                for (int i = 0, j = 0; i < parStr1._charString.Length; i++, j++)
                {
                    if (parStr1._charString[i] != parStr2._charString[j])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Converting results to string
        /// </summary>
        /// <returns> String</returns>
        public override string ToString()
        {
            StringBuilder outputString = new StringBuilder();
            foreach (var symbol in _charString)
            {
                outputString.Append(symbol);
            }
            return outputString.ToString();
        }
    }
}
