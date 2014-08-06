using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace mIRCBotCmdHarness
{
    class Program
    {

        public static Random randGenerator = new Random();
        protected static genericIRCBot bot;

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            bot = new genericIRCBot("irc.otherworlders.org", 6667, "cmdicebot");
            //genericIRCBot bot = new genericIRCBot("irc.rizon.net", 6667, "cmdicebot");

            bot.PrivmsgArrived += bot_PrivmsgArrived;

            bot.ConnectServer();

            //Thread.Sleep(10000);

            bot.JoinChannel("#sandsociety");
            Thread.Sleep(1000);
            //bot.messageChannel("#narutod20", "Testing Messaging Capabilities.");
            //Thread.Sleep(1000);
            //bot.messagePerson("cm", "Testing Private Messaging Capabilities.");
            //Thread.Sleep(1000);

            while(true)

            //for (int i = 0; i < 500; i++)
            {
                Thread.Sleep(1000);
            }
            //bot.DisconnectServer();

            //Environment.Exit(0);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            bot.DisconnectServer();
            Environment.Exit(0);
        }

        static void bot_PrivmsgArrived(object sender, IRCMessage message)
        {
            char boldChar = '\u0002';
            //If it starts with dice rolls, then it's a line that is a request to roll dice.
            //if it starts with roll, it's a line that is a request to roll dice.
            Regex diceRollRegex = new Regex(@"^\d*#?\d*d(?<dienumber>\d+)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            Regex diceRollRegex2 = new Regex(@"^roll \d*#?\d*d(?<dienumber>\d+)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
            Regex basicNumbering = new Regex(@"(?<number>\d+)#", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

            if (diceRollRegex.IsMatch(message.Message) || diceRollRegex2.IsMatch(message.Message))
            {
                string targetToSendTo = "";
                if (message.Target == Program.bot.textNickname)
                {
                    targetToSendTo = message.Sender;
                }
                else
                {
                    targetToSendTo = message.Target;
                }

                try
                {
                    StringBuilder messageToSend = new StringBuilder();
                    messageToSend.Append(message.Sender);
                    messageToSend.Append(" rolls ");
                    List<string> calculationsToCalculate = new List<string>();
                    List<string> completedCalculations = new List<string>();
                    List<int> totals = new List<int>();

                    //Determine the seperate chunks between the dice-rolling portion and the after-message
                    Regex diceRollRegex3 = new Regex(@"(?<dierolls>[\d#d; +-]+)(?<message>.*)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

                    if (!diceRollRegex3.IsMatch(message.Message))
                    {
                        Program.bot.messagePerson(targetToSendTo, "I'm sorry, there's been a parsing error.  Please try again.  Message: '" + message.Message + "'");
                        return;
                    }

                    Match giantMatch = diceRollRegex3.Match(message.Message);

                    string dicerollsblock = giantMatch.Groups["dierolls"].Value;
                    string finalMessage = giantMatch.Groups["message"].Value;

                    dicerollsblock = dicerollsblock.Replace(" ", "");
                    messageToSend.Append(boldChar);
                    messageToSend.Append(dicerollsblock);
                    messageToSend.Append(boldChar);

                    //Parse out all the calculations needed by parsing by ;
                    string[] calculationGroups = dicerollsblock.Split(new char[] { ';' });

                    for (int i = 0; i < calculationGroups.Length; i++)
                    {
                        string individualCalc = calculationGroups[i];
                        if (individualCalc.Contains('#'))
                        {
                            individualCalc = calculationGroups[i].Split('#')[1];
                        }

                        int calcNumber = 1;
                        //TODO: Parse out all the calculations needed by parsing the #'s
                        if (basicNumbering.IsMatch(calculationGroups[i]))
                        {
                            calcNumber = Int32.Parse(basicNumbering.Match(calculationGroups[i]).Groups["number"].Value);
                        }

                        for (int j = 0; j < calcNumber; j++)
                        {
                            calculationsToCalculate.Add(individualCalc);
                        }
                    }

                    //One at a time, process the calculations (In sub-function) and populate the completedCalculations and totals sections
                    for (int k = 0; k < calculationsToCalculate.Count; k++)
                    {
                        ProcessCalculation(calculationsToCalculate[k], ref completedCalculations, ref totals);
                    }

                    messageToSend.Append(" [");

                    for (int i = 0; i < completedCalculations.Count; i++)
                    {
                        if (i != 0)
                        {
                            messageToSend.Append(", ");
                        }

                        messageToSend.Append(completedCalculations[i]);
                        messageToSend.Append(" = ");
                        messageToSend.Append(boldChar);
                        messageToSend.Append(totals[i]);
                        messageToSend.Append(boldChar);
                    }

                    messageToSend.Append("] = ");
                    messageToSend.Append(boldChar);
                    messageToSend.Append("[");

                    for (int i = 0; i < totals.Count; i++)
                    {
                        if (i != 0)
                        {
                            messageToSend.Append(", ");
                        }

                        messageToSend.Append(totals[i]);
                    }

                    messageToSend.Append("]");
                    messageToSend.Append(boldChar);

                    messageToSend.Append(" ");
                    messageToSend.Append(finalMessage);

                    if (messageToSend.Length > 1200)
                    {
                        Program.bot.messagePerson(targetToSendTo, message.Sender + ": I'm sorry, but there are too many results to send to you!  Break your request into smaller amounts!");
                    }
                    else if (messageToSend.Length < 400)
                    {
                        Program.bot.messagePerson(targetToSendTo, messageToSend.ToString());
                    }
                    else
                    {
                        int messagesCt = (messageToSend.Length / 400) + 1;

                        for (int i = 0; i < messagesCt; i++)
                        {
                            string currentMessage = messageToSend.ToString().Substring(i * 500, 500);
                            Program.bot.messagePerson(targetToSendTo, currentMessage);
                            Thread.Sleep(2000);
                        }
                    }


                }
                catch (Exception)
                {
                    Program.bot.messagePerson(targetToSendTo, message.Sender + ": I'm sorry, there's been a parsing error.  Please try again.  Message: '" + message.Message + "'");
                    return;
                }

                //Example Messages:
                //CM: 1d20
                //Bot: CM rolls 1d20 [(17)] = 17 {Message}
                //CM: 1d20+12+1d6 Sneak Attack
                //Bot: CM rolls 1d20+12+1d6 [(17)+12+(3)] = 32 Sneak Attack
                //CM: 4#1d20+15 Attacks
                //Bot: CM rolls 4#1d20+15 [(15)+15], [(9)+15], [(4)+15], [(1)+15] = 30, 24, 19, 16 Attacks
                //CM: 1d20+20; 1d20+15 Attacks
                //Bot: CM rolls 1d20+20; 1d20+15 [(9)+20], [(14)+15] = 29, 29 Attacks
            }
        }

        private static void ProcessCalculation(string calculation, ref List<string> completedCalcs, ref List<int> totals)
        {
            string calculationInProcessing = calculation;
            string completedString = "";
            int total = 0;
            bool additionOrSubtraction = true;
            Regex isDiceRoll = new Regex(@"(?<diemultipler>\d*)d(?<dienumber>\d+)", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

            string[] sectionsForCalculation = calculation.Split(new char[] { '+', '-' });

            for (int i = 0; i < sectionsForCalculation.Length; i++)
            {
                //Determine for each section, whether it's a plus or subtraction from the Total
                if (i != 0)
                {
                    char spotter = calculationInProcessing[0];

                    if (spotter == '+')
                    {
                        additionOrSubtraction = true;
                        completedString += "+";
                    }
                    else
                    {
                        additionOrSubtraction = false;
                        completedString += "-";
                    }
                    calculationInProcessing = calculationInProcessing.Substring(1);
                }

                int value = 0;
                //TODO: Determine if the value is dice rolls or a static integer
                if (isDiceRoll.IsMatch(sectionsForCalculation[i]))
                {
                    int diemulti = 1;
                    int diefaces = 0;
                    Match dice = isDiceRoll.Match(sectionsForCalculation[i]);
                    if (!String.IsNullOrEmpty(dice.Groups["diemultipler"].Value))
                    {
                        diemulti = Int32.Parse(dice.Groups["diemultipler"].Value);
                    }

                    diefaces = Int32.Parse(dice.Groups["dienumber"].Value);

                    completedString += "(";

                    for (int j = 0; j < diemulti; j++)
                    {
                        int curValue = Program.randGenerator.Next(1, diefaces);
                        if (j != 0)
                        {
                            completedString += ",";
                        }
                        completedString += curValue;
                        value += curValue;
                    }

                    completedString += ")";
                }
                else
                {
                    if (!Int32.TryParse(sectionsForCalculation[i], out value))
                    {
                        throw new InvalidOperationException("Parsing Error");
                    }

                    completedString += value;
                }

                if (additionOrSubtraction)
                {
                    total += value;
                }
                else
                {
                    total -= value;
                }

                calculationInProcessing = calculationInProcessing.Substring(sectionsForCalculation[i].Length);
            }

            completedCalcs.Add(completedString);
            totals.Add(total);
        }
    }
}
