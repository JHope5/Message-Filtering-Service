using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapierBank
{
    public partial class SendTweet : Form
    {
        public SendTweet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = txtTweet.Text;
            string username = txtUsername.Text;

            // Validation
            if (message == "" || username == "")
            {
                MessageBox.Show("Invalid input. Boxes cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (message.Length > 140)
            {
                MessageBox.Show("Tweet exceeds 140 character limit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((username.Length > 15) || (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$")))
            {
                MessageBox.Show("Invalid username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                #region Expanding Textspeak
                message = Regex.Replace(message, "AAP", "AAP<Always a pleasure>");
                message = Regex.Replace(message, "AAR", "AAR<At any rate");
                message = Regex.Replace(message, "AAS", "AAS<Alive and smiling>");
                message = Regex.Replace(message, "ADN", "ADN<Any day now>");
                message = Regex.Replace(message, "AEAP", "AEAP<As early as possible");
                message = Regex.Replace(message, "AFAIK", "AFAIK<As far as I know>");
                message = Regex.Replace(message, "AFK", "AFK<Away from keyboard>");
                message = Regex.Replace(message, "AKA", "AKA<Also known as>");
                message = Regex.Replace(message, "AISB", "AISB<As it should be>");
                message = Regex.Replace(message, "AOTA", "AOTA<All of the above>");
                message = Regex.Replace(message, "ASAP", "ASAP<As soon as possible>");
                message = Regex.Replace(message, "A/S/L", "A/S/L<Age/sex/location>");
                message = Regex.Replace(message, "AT", "AT<At your terminal>");
                message = Regex.Replace(message, "ATM", "ATM<At the moment>");
                message = Regex.Replace(message, "AYEC", "AYEC<At your earliest convenience>");
                message = Regex.Replace(message, "B/F", "B/F<Boyfriend>");
                message = Regex.Replace(message, "B4", "B4<Before>");
                message = Regex.Replace(message, "B4N", "B4N<Bye for now>");
                message = Regex.Replace(message, "BAK", "BAK<Back at keyboard>");
                message = Regex.Replace(message, "BAU", "BAS<Business as usual>");
                message = Regex.Replace(message, "BBIAF", "BBIAF<Be back in a few>");
                message = Regex.Replace(message, "BBIAM", "BBIAM<Be back in a minute>");
                message = Regex.Replace(message, "BBL", "BBL<Be back later>");
                message = Regex.Replace(message, "BBS", "BBS<Be back soon>");
                message = Regex.Replace(message, "BC", "BC<Because>");
                message = Regex.Replace(message, "BCNU", "BCNU<Be seeing you>");
                message = Regex.Replace(message, "BF", "BF<Best friend>");
                message = Regex.Replace(message, "BFN", "BFN<Bye for now>");
                message = Regex.Replace(message, "BLNT", "BLNT<Better luck next time>");
                message = Regex.Replace(message, "BM&Y", "BM&Y<Between me and you>");
                message = Regex.Replace(message, "BOL", "BOL<Best of luck>");
                message = Regex.Replace(message, "BRB", "BRB<Be right back>");
                message = Regex.Replace(message, "BRT", "BRT<Be right there>");
                message = Regex.Replace(message, "BTA", "BTA<But then again>");
                message = Regex.Replace(message, "BTDT", "BTDT<Been there done that>");
                message = Regex.Replace(message, "BTW", "BTW<By the way>");
                message = Regex.Replace(message, "CMIIW", "CMIIW<Correct me if I'm wrong>");
                message = Regex.Replace(message, "CMON", "CMON<Come on>");
                message = Regex.Replace(message, "COB", "COB<Close of business>");
                message = Regex.Replace(message, "CU", "CU<See you>");
                message = Regex.Replace(message, "CUA", "CUA<See you around>");
                message = Regex.Replace(message, "CUL", "CUL<See you later>");
                message = Regex.Replace(message, "CUL8R", "CUL8R<See you later>");
                message = Regex.Replace(message, "CWYL", "CWYL<Chat with you later>");
                message = Regex.Replace(message, "CYA", "CYA<See ya>");
                message = Regex.Replace(message, "CYO", "CYO<See you online>");
                message = Regex.Replace(message, "D/L", "D/L<Download>");
                message = Regex.Replace(message, "DEGT", "DEGT<Don't even go there>");
                message = Regex.Replace(message, "DIKU", "DIKU<Do I know you?>");
                message = Regex.Replace(message, "DQMOT", "DQMOT<Don't quote me on this>");
                message = Regex.Replace(message, "DTS", "DTS<Don't think so>");
                message = Regex.Replace(message, "EBKAC", "EBKAC<Error between keyboard and chair>");
                message = Regex.Replace(message, "EMA", "EMA<E-mail address>");
                message = Regex.Replace(message, "EOD", "EOD<End of day>");
                message = Regex.Replace(message, "EOM", "EOM<End of message>");
                message = Regex.Replace(message, "F2F", "F2F<Face to face>");
                message = Regex.Replace(message, "FBM", "FBM<Fine by me>");
                message = Regex.Replace(message, "FISH", "FISH<First in, still here>");
                message = Regex.Replace(message, "FOMCL", "FOMCL<Falling off my chair laughing>");
                message = Regex.Replace(message, "FITB", "FITB<Fill in the blank>");
                message = Regex.Replace(message, "FRT", "FRT<For real though>");
                message = Regex.Replace(message, "FWIW", "FWIW<For what it's worth>");
                message = Regex.Replace(message, "FYEO", "FYEO<For your eyes only>");
                message = Regex.Replace(message, "FYI", "FYI<For your information>");
                message = Regex.Replace(message, "G/F", "G/F<Girlfriend>");
                message = Regex.Replace(message, "G2G", "G2G<Got to go>");
                message = Regex.Replace(message, "G2R", "G2R<Got to run>");
                message = Regex.Replace(message, "GA", "GA<Go ahead>");
                message = Regex.Replace(message, "GAL", "GAL<Get a life>");
                message = Regex.Replace(message, "GB", "GB<Goodbye>");
                message = Regex.Replace(message, "GBU", "GBU<God bless you>");
                message = Regex.Replace(message, "GFI", "GFI<Go for it>");
                message = Regex.Replace(message, "GG", "GG<Gotta go / Good game>");
                message = Regex.Replace(message, "GIAR", "GIAR<Give it a rest>");
                message = Regex.Replace(message, "GIGO", "GIGO<Garbage in, garbage out>");
                message = Regex.Replace(message, "GL", "GL<Good luck>");
                message = Regex.Replace(message, "GL/HF", "GL/HF<Good luck, have fun>");
                message = Regex.Replace(message, "GLNG", "GLNG<Good luck next game>");
                message = Regex.Replace(message, "GMTA", "GMTA<Great minds think alike>");
                message = Regex.Replace(message, "GOI", "GOI<Get over it>");
                message = Regex.Replace(message, "GOL", "GOL<Giggling out loud>");
                message = Regex.Replace(message, "GR8", "GR8<Great>");
                message = Regex.Replace(message, "GR&D", "GR&D<Grinning, running and ducking>");
                message = Regex.Replace(message, "GTG", "GTG<Got to go>");
                message = Regex.Replace(message, "GTRM", "GTRM<Going to read mail>");
                message = Regex.Replace(message, "HAGN", "HAGN<Have a good night>");
                message = Regex.Replace(message, "HAGO", "HAGO<Have a good one>");
                message = Regex.Replace(message, "HAND", "HAND<Have a nice day>");
                message = Regex.Replace(message, "HF", "HF<Have fun>");
                message = Regex.Replace(message, "HHIS", "HHIS<Head hanging in shame>");
                message = Regex.Replace(message, "HOAS", "HOAS<Hold on a second>");
                message = Regex.Replace(message, "HRU", "HRU<How are you?");
                message = Regex.Replace(message, "HTH", "HTH<Hope this helps>");
                message = Regex.Replace(message, "IAC", "IAC<In any case>");
                message = Regex.Replace(message, "IANAL", "IANAL<I am not a lawyer>");
                message = Regex.Replace(message, "IB", "IB<I'm back>");
                message = Regex.Replace(message, "IC", "IC<I see>");
                message = Regex.Replace(message, "ICBW", "ICBW<It could be worse>");
                message = Regex.Replace(message, "IDK", "IDK<I don't know>");
                message = Regex.Replace(message, "IDTS", "IDTS<I don't think so>");
                message = Regex.Replace(message, "IG2R", "IG2R<I got to run>");
                message = Regex.Replace(message, "IIRC", "IIRC<If I remember correctly>");
                message = Regex.Replace(message, "ILBL8", "ILBL8<I'll be late>");
                message = Regex.Replace(message, "ILU", "ILU<I love you>");
                message = Regex.Replace(message, "ILY", "ILY<I love you>");
                message = Regex.Replace(message, "IM", "IM<Instant message>");
                message = Regex.Replace(message, "IMHO", "IMHO<In my humble opinion>");
                message = Regex.Replace(message, "IMNSHO", "IMNSHO<In my not so humble opinion>");
                message = Regex.Replace(message, "IMO", "IMO<In my opinion>");
                message = Regex.Replace(message, "INAL", "INAL<I'm not a lawyer>");
                message = Regex.Replace(message, "IOW", "IOW<In other words>");
                message = Regex.Replace(message, "IRL", "IRL<In real life>");
                message = Regex.Replace(message, "IRMC", "IRMC<I rest my case>");
                message = Regex.Replace(message, "IUSS", "IUSS<If you say so>");
                message = Regex.Replace(message, "IYKWIM", "IYKWIM<If you know what I mean>");
                message = Regex.Replace(message, "IYO", "IYO<In your opinion>");
                message = Regex.Replace(message, "IYSS", "IYSS<If you say so>");
                message = Regex.Replace(message, "JAC", "JAC<Just a sec>");
                message = Regex.Replace(message, "JIK", "JIK<Just in case>");
                message = Regex.Replace(message, "JJA", "JJA<Just joking around>");
                message = Regex.Replace(message, "JK", "JK<Just kidding>");
                message = Regex.Replace(message, "JMO", "JMO<Just my opinion>");
                message = Regex.Replace(message, "JP", "JP<Just playing>");
                message = Regex.Replace(message, "KISS", "KISS<Keep it simple, stupid>");
                message = Regex.Replace(message, "KIT", "KIT<Keep in touch>");
                message = Regex.Replace(message, "KOTC", "KOTC<Kiss on the cheek>");
                message = Regex.Replace(message, "KNIM", "KNIM<Know what I mean>");
                message = Regex.Replace(message, "L8R", "L8R<Later>");
                message = Regex.Replace(message, "LD", "LD<Later dude / Long distance>");
                message = Regex.Replace(message, "LMAO", "LMAO<Laughing my a** off>");
                message = Regex.Replace(message, "LOL", "LOL<Laughing out loud>");
                message = Regex.Replace(message, "LTM", "LTM<Laugh to myself>");
                message = Regex.Replace(message, "LTNS", "LTNS<Long time no see>");
                message = Regex.Replace(message, "LYLAS", "LYLAS<Love you like a sis>");
                message = Regex.Replace(message, "M8", "M8<Mate>");
                message = Regex.Replace(message, "MorF", "MorF<Male or female?>");
                message = Regex.Replace(message, "MoS", "MoS<Mother over shoulder>");
                message = Regex.Replace(message, "MUSM", "MUSM<Miss you so much>");
                message = Regex.Replace(message, "MYOB", "MYOB<Mind your own business>");
                message = Regex.Replace(message, "n00b", "n00b<Newbie>");
                message = Regex.Replace(message, "NBD", "NBD<No big deal>");
                message = Regex.Replace(message, "NFM", "NFM<None for me / Not for me>");
                message = Regex.Replace(message, "NIMBY", "NIMBY<Not in my back yard>");
                message = Regex.Replace(message, "NLT", "NLT<No later than>");
                message = Regex.Replace(message, "NM", "NM<Nothing much / Never mind>");
                message = Regex.Replace(message, "NMH", "NMH<Not much here>");
                message = Regex.Replace(message, "NOYB", "NOYB<None of your business>");
                message = Regex.Replace(message, "NP", "NP<No problem>");
                message = Regex.Replace(message, "NRN", "NRN<No respoonce/reply necessary>");
                message = Regex.Replace(message, "NW", "NW<No way>");
                message = Regex.Replace(message, "OIC", "OIC<Oh, I see>");
                message = Regex.Replace(message, "OMG", "OMG<Oh my god>");
                message = Regex.Replace(message, "OMW", "OMW<On my way>");
                message = Regex.Replace(message, "OO", "OO<Over and out>");
                message = Regex.Replace(message, "OOH", "OOH<Out of here>");
                message = Regex.Replace(message, "OOTD", "OOTD<One of these days>");
                message = Regex.Replace(message, "OP", "OP<On phone>");
                message = Regex.Replace(message, "OTB", "OTB<Off to bed>");
                message = Regex.Replace(message, "OTL", "OTL<Out to lunch>");
                message = Regex.Replace(message, "OTOH", "OTOH<On the other hand>");
                message = Regex.Replace(message, "OTTOMH", "OTTOMH<Off the top of my head>");
                message = Regex.Replace(message, "OTW", "OTW<Off to work>");
                message = Regex.Replace(message, "PDQ", "PDQ<Pretty darn quick>");
                message = Regex.Replace(message, "PITA", "PITA<Pain in the a**>");
                message = Regex.Replace(message, "PLMK", "PLMK<Please let me know>");
                message = Regex.Replace(message, "PLZ", "PLZ<Please>");
                message = Regex.Replace(message, "PMFI", "PMFI<Pardon me for interrupting>");
                message = Regex.Replace(message, "PMFJI", "PMFJI<Pardon me for jumping in>");
                message = Regex.Replace(message, "POAHF", "POAHF<Put on a happy face>");
                message = Regex.Replace(message, "POS", "POS<Parent over shoulder>");
                message = Regex.Replace(message, "PPL", "PPL<People>");
                message = Regex.Replace(message, "PRW", "PRW<People/parents are watching>");
                message = Regex.Replace(message, "PTL", "PTL<Praise the Lord>");
                message = Regex.Replace(message, "PXT", "PXT<Please explain this>");
                message = Regex.Replace(message, "PU", "PU<That stinks!>");
                message = Regex.Replace(message, "QIK", "QIK<Quick>");
                message = Regex.Replace(message, "RL", "RL<Real life>");
                message = Regex.Replace(message, "RME", "RME<Rolling my eyes>");
                message = Regex.Replace(message, "ROTFL", "ROTFL<Rolling on the floor laughing>");
                message = Regex.Replace(message, "RSN", "RSN<Real soon now>");
                message = Regex.Replace(message, "RTFM", "RTFM<Read the f****** manual>");
                message = Regex.Replace(message, "SICNR", "SICNR<Sorry, I could not resist>");
                message = Regex.Replace(message, "SIG2R", "SIG2R<Sorry, I got to run>");
                message = Regex.Replace(message, "SLAP", "SLAP<Sounds like a plan>");
                message = Regex.Replace(message, "SMHID", "SMHID<Scratching my head in disbelief>");
                message = Regex.Replace(message, "SIS", "SIS<Snickering in silence>");
                message = Regex.Replace(message, "SOMY", "SOMY<Sick of me yet?>");
                message = Regex.Replace(message, "SOTMG", "SOTMG<Short of time, must go>");
                message = Regex.Replace(message, "SPK", "SPK<Speak>");
                message = Regex.Replace(message, "SPST", "SPST<Same place, same time>");
                message = Regex.Replace(message, "SRY", "SRY<Sorry>");
                message = Regex.Replace(message, "SS", "SS<So sorry>");
                message = Regex.Replace(message, "SSDD", "SSDD<Same stuff, different day>");
                message = Regex.Replace(message, "SSINF", "SSINF<So stupid it's not funny>");
                message = Regex.Replace(message, "STR8", "STR8<Straight>");
                message = Regex.Replace(message, "STW", "STW<Search the Web)");
                message = Regex.Replace(message, "SUITM", "SUITM<See you in the morning>");
                message = Regex.Replace(message, "SUL", "SUL<See you later>");
                message = Regex.Replace(message, "SUP", "SUP<What's up?>");
                message = Regex.Replace(message, "SYL", "SYL<See you later>");
                message = Regex.Replace(message, "TA", "TA<Thanks alot>");
                message = Regex.Replace(message, "TAFN", "TAFN<That's all for now>");
                message = Regex.Replace(message, "TAM", "Tomorrow a.m.>");
                message = Regex.Replace(message, "TBD", "TBD<To be determined>");
                message = Regex.Replace(message, "TBH", "TBH<To be honest>");
                message = Regex.Replace(message, "TC", "TC<Take care>");
                message = Regex.Replace(message, "TGIF", "TGIF<Thank God it's Friday>");
                message = Regex.Replace(message, "THX", "THX<Thanks>");
                message = Regex.Replace(message, "TIA", "TIA<Thanks in advance>");
                message = Regex.Replace(message, "TIAD", "TIAD<Tomorrow is another day>");
                message = Regex.Replace(message, "TLK2UL8R", "TLK2UL8R<Talk to you later>");
                message = Regex.Replace(message, "TMI", "TMI<Too much information>");
                message = Regex.Replace(message, "TMWFI", "TMWFI<Take my word for it>");
                message = Regex.Replace(message, "TNSTAAFL", "TNSTAAFL<There's no such thing as a free lunch>");
                message = Regex.Replace(message, "TPM", "TPM<Tomorrow p.m.>");
                message = Regex.Replace(message, "TPTB", "TPTB<The powers that be>");
                message = Regex.Replace(message, "TSTB", "TSTB<The sooner the better>");
                message = Regex.Replace(message, "TTFN", "TTFN<Ta ta for now>");
                message = Regex.Replace(message, "TTTT", "TTTT<These things take time>");
                message = Regex.Replace(message, "TTYL", "TTYL<Talk to you later>");
                message = Regex.Replace(message, "TTYS", "TTYS<Talk to you soon>");
                message = Regex.Replace(message, "TU", "TU<Thank you>");
                message = Regex.Replace(message, "TY", "TY<Thank you>");
                message = Regex.Replace(message, "TYT", "TYT<Take your time>");
                message = Regex.Replace(message, "TYVM", "TYVM<Thank you very much>");
                message = Regex.Replace(message, "UGTBK", "UGTBK<You've got to be kidding>");
                message = Regex.Replace(message, "UKTR", "UKTR<You know that's right>");
                message = Regex.Replace(message, "UL", "UL<Upload>");
                message = Regex.Replace(message, "UR", "UR<Your / You're>");
                message = Regex.Replace(message, "UV", "UV<Unpleasant visual>");
                message = Regex.Replace(message, "UW", "UW<You're welcome>");
                message = Regex.Replace(message, "WAM", "WAM<Wait a minute>");
                message = Regex.Replace(message, "WAN2TLK", "WAN2TLK<Want to talk>");
                message = Regex.Replace(message, "WAYF", "WAYF<Where are you from?>");
                message = Regex.Replace(message, "W/B", "W/B<Write back>");
                message = Regex.Replace(message, "WB", "WB<Welcome back>");
                message = Regex.Replace(message, "WIIFM", "WIIFM<What's in it for me?>");
                message = Regex.Replace(message, "WK", "WK<Week>");
                message = Regex.Replace(message, "WKD", "WKD<Weekend>");
                message = Regex.Replace(message, "WOMBAT", "WOMBAT<Waste of money, brains and time>");
                message = Regex.Replace(message, "WRUD", "WRUD<What are you doing?>");
                message = Regex.Replace(message, "WTF", "WTF<What the f***?>");
                message = Regex.Replace(message, "WTG", "WTG<Way to go>");
                message = Regex.Replace(message, "WTH", "WTH<What the heck?>");
                message = Regex.Replace(message, "WU", "WU?<What's up?>");
                message = Regex.Replace(message, "WUCIWUG", "WUCIWUG<What you see is what you get>");
                message = Regex.Replace(message, "WUF", "WUF?<Where are you from?>");
                message = Regex.Replace(message, "WWJD", "WWJD<What would Jesus do?>");
                message = Regex.Replace(message, "WWYC", "WWYC<Write when you can>");
                message = Regex.Replace(message, "WYLEI", "WYLEI<When you least expect it>");
                message = Regex.Replace(message, "WYSIWYG", "WYSIWYG<What you see is what you get>");
                message = Regex.Replace(message, "YBS", "YBS<You'll be sorry>");
                message = Regex.Replace(message, "YGBKM", "YGBKM<You gotta be kidding me>");
                message = Regex.Replace(message, "YMMV", "YMMV<Your mileage may vary>");
                message = Regex.Replace(message, "YW", "YW<You're welcome>");
                #endregion

                #region Storing Hashtags
                foreach (Match match in Regex.Matches(message, @"(?<!\w)#\w+"))
                {

                    File.AppendAllText("Trending.json", " - " + match.Value);
                }
                #endregion

                #region Storing Mentions
                foreach (Match match in Regex.Matches(message, @"(?<!\w)@\w+"))
                {
                    File.AppendAllText("Mentions.json", " - " + match.Value);
                }
                #endregion

                string messageID = IDCreator();
                string body = BodyCreator(message, username);

                // Creating a tweet from the information provided
                List<Tweet> tweets = new List<Tweet>();
                tweets.Add(new Tweet()
                {
                    messageID = IDCreator(),
                    messageBody = BodyCreator(message, username)
                });
                string json = JsonConvert.SerializeObject(tweets.ToArray());

                // Writing the information to the file
                File.AppendAllText("Tweets.json", json);

                // Displaying a message and redirecting the user to the Main Menu
                MessageBox.Show("Tweet added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Close();
            }
        }

        // Generating a random 9 digits for the Message ID
        private string IDCreator()
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
            string id = "T" + s;
            return id;
        }

        // Placing the username as the sender and the tweet as the message text
        private string BodyCreator(string tweet, string username)
        {
            string body = "Sender: @" + username + " - Message Text: " + tweet;
            return body;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
