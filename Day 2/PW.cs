namespace Day2
{
    internal class PW
    {
        public string pw;
        public int minChar;
        public int maxChar;
        public char targetChar;
        public bool validPW;

        public PW(int MinChar, int MaxChar, char TargetChar, string PassWord)
        {
            pw = PassWord;
            minChar = MinChar;
            maxChar = MaxChar;
            targetChar = TargetChar;
        }

        public PW(string inputLine)
        {
            string[] splited = inputLine.Split(' '); ;
            string[] min_max = splited[0].Split('-');
            targetChar = splited[1].ToCharArray()[0];
            pw = splited[2];
            minChar = int.Parse(min_max[0]);
            maxChar = int.Parse(min_max[1]);
            //CheckIfValidPW1();
            validPW = false;
            CheckIfValidPW2();
        }

        public override string ToString()
        {
            string output = "Password: " + pw + "\nMin-Max: " + minChar + "-" + maxChar + "\nTargetChar: " + targetChar;
            return output;
        }

        public void CheckIfValidPW1()
        {
            int count = 0;
            char[] pwArr = pw.ToCharArray();
            foreach (char chPw in pwArr)
            {
                if (chPw == targetChar)
                {
                    count++;
                }
            }
            if (count <= maxChar && count >= minChar)
            {
                validPW = true;
                return;
            }
            validPW = false;
        }
        public void CheckIfValidPW2()
        {
            char[] pwArr = pw.ToCharArray();
            if (pwArr[minChar-1] == targetChar)
            {
                FlipValid();
            }
            if (pwArr[maxChar-1] == targetChar) 
            {
                FlipValid();   
            }
        }

        private void FlipValid()
        {
            if (validPW)
                validPW = false;
            else
                validPW = true;
        }
    }
}