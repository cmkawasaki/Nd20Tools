using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mIRCBotCmdHarness
{
    public class IRCMessage
    {
        public string Sender { get; set; }
        public string CommandName { get; set; }
        public string Target { get; set; }
        public string Message { get; set; }

        public IRCMessage(string ircMessage)
        {
            if(ircMessage == null)
            {
                throw new InvalidOperationException();
            }

            //Regex messagePatternMatch = new Regex(@"^:(?<source>\f+) (?<CommandName>\f+) (?<Target>\f+) :(?<Message>\.*)$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            Regex messagePatternMatch = new Regex(@":(?<source>[\w,.~!@*\#-]+) (?<CommandName>[\w,.~!@*\#-]+) (?<Target>[\w,.~!@*\#-]+) ?:?(?<Message>.*)", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

            if(messagePatternMatch.IsMatch(ircMessage))
            {
                Match messageParser = messagePatternMatch.Match(ircMessage);
                this.Message = messageParser.Groups["Message"].Value;
                this.Target = messageParser.Groups["Target"].Value;
                this.CommandName = messageParser.Groups["CommandName"].Value;
                this.Sender = messageParser.Groups["source"].Value;
                if(this.Sender.IndexOf('!') > -1)
                {
                    this.Sender = this.Sender.Split(new char[] { '!' })[0];
                }
            }
            else
            {
                this.Sender = "";
                this.CommandName = "FAILED";
                this.Target = "";
                this.Message = "";
                //Ignore for now
                //Console.WriteLine("Command could not be parsed: " + ircMessage);
            }
        }
    }
}
