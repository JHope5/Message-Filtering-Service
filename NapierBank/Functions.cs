using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NapierBank
{
    class Functions
    {
        public string Expand(string message)
        {
            message = Regex.Replace(message, @"\bAAP\b", "AAP<Always a pleasure>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAAR\b", "AAR<At any rate", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAAS\b", "AAS<Alive and smiling>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bADN\b", "ADN<Any day now>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAEAP\b", "AEAP<As early as possible", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAFAIK\b", "AFAIK<As far as I know>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAFK\b", "AFK<Away from keyboard>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAKA\b", "AKA<Also known as>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAISB\b", "AISB<As it should be>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAOTA\b", "AOTA<All of the above>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bASAP\b", "ASAP<As soon as possible>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bA/S/L\b", "A/S/L<Age/sex/location>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bATM\b", "ATM<At the moment>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bAYEC\b", "AYEC<At your earliest convenience>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bB/F\b", "B/F<Boyfriend>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bB4\b", "B4<Before>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bB4N\b", "B4N<Bye for now>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBAK\b", "BAK<Back at keyboard>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBBIAF\b", "BBIAF<Be back in a few>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBBIAM\b", "BBIAM<Be back in a minute>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBBL\b", "BBL<Be back later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBBS\b", "BBS<Be back soon>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBCNU\b", "BCNU<Be seeing you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBF\b", "BF<Best friend>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBFN\b", "BFN<Bye for now>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBLNT\b", "BLNT<Better luck next time>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBM&Y\b", "BM&Y<Between me and you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBRB\b", "BRB<Be right back>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBRT\b", "BRT<Be right there>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBTA\b", "BTA<But then again>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBTDT\b", "BTDT<Been there done that>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bBTW\b", "BTW<By the way>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCMIIW\b", "CMIIW<Correct me if I'm wrong>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCMON\b", "CMON<Come on>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCUA\b", "CUA<See you around>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCUL\b", "CUL<See you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCUL8R\b", "CUL8R<See you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCWYL\b", "CWYL<Chat with you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCYA\b", "CYA<See ya>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bCYO\b", "CYO<See you online>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bD/L\b", "D/L<Download>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bDEGT\b", "DEGT<Don't even go there>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bDIKU\b", "DIKU<Do I know you?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bDQMOT\b", "DQMOT<Don't quote me on this>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bDTS\b", "DTS<Don't think so>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bEBKAC\b", "EBKAC<Error between keyboard and chair>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bEMA\b", "EMA<E-mail address>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bEOD\b", "EOD<End of day>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bEOM\b", "EOM<End of message>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bF2F\b", "F2F<Face to face>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFBM\b", "FBM<Fine by me>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFISH\b", "FISH<First in, still here>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFOMCL\b", "FOMCL<Falling off my chair laughing>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFITB\b", "FITB<Fill in the blank>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFRT\b", "FRT<For real though>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFWIW\b", "FWIW<For what it's worth>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFYEO\b", "FYEO<For your eyes only>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bFYI\b", "FYI<For your information>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bG/F\b", "G/F<Girlfriend>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bG2G\b", "G2G<Got to go>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bG2R\b", "G2R<Got to run>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGA\b", "GA<Go ahead>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGAL\b", "GAL<Get a life>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGB\b", "GB<Goodbye>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGBU\b", "GBU<God bless you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGFI\b", "GFI<Go for it>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGG\b", "GG<Gotta go / Good game>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGIAR\b", "GIAR<Give it a rest>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGIGO\b", "GIGO<Garbage in, garbage out>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGL\b", "GL<Good luck>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGL/HF\b", "GL/HF<Good luck, have fun>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGLNG\b", "GLNG<Good luck next game>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGMTA\b", "GMTA<Great minds think alike>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\\bGOI\b", "GOI<Get over it>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGOL\b", "GOL<Giggling out loud>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGR8\b", "GR8<Great>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGR&D\b", "GR&D<Grinning, running and ducking>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGTG\b", "GTG<Got to go>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bGTRM\b", "GTRM<Going to read mail>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHAGN\b", "HAGN<Have a good night>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHAGO\b", "HAGO<Have a good one>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHAND\b", "HAND<Have a nice day>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHF\b", "HF<Have fun>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHHIS\b", "HHIS<Head hanging in shame>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHOAS\b", "HOAS<Hold on a second>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHRU\b", "HRU<How are you?", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bHTH\b", "HTH<Hope this helps>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIAC\b", "IAC<In any case>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIANAL\b", "IANAL<I am not a lawyer>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIB\b", "IB<I'm back>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIC\b", "IC<I see>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bICBW\b", "ICBW<It could be worse>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIDK\b", "IDK<I don't know>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIDTS\b", "IDTS<I don't think so>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIG2R\b", "IG2R<I got to run>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIIRC\b", "IIRC<If I remember correctly>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bILBL8\b", "ILBL8<I'll be late>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bILU\b", "ILU<I love you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bILY\b", "ILY<I love you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIM\b", "IM<Instant message>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIMHO\b", "IMHO<In my humble opinion>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIMNSHO\b", "IMNSHO<In my not so humble opinion>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIMO\b", "IMO<In my opinion>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bINAL\b", "INAL<I'm not a lawyer>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIOW\b", "IOW<In other words>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIRL\b", "IRL<In real life>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIRMC\b", "IRMC<I rest my case>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIUSS\b", "IUSS<If you say so>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIYKWIM\b", "IYKWIM<If you know what I mean>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIYO\b", "IYO<In your opinion>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bIYSS\b", "IYSS<If you say so>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bJIK\b", "JIK<Just in case>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bJJA\b", "JJA<Just joking around>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bJK\b", "JK<Just kidding>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bJMO\b", "JMO<Just my opinion>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bJP\b", "JP<Just playing>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bKOTC\b", "KOTC<Kiss on the cheek>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bKNIM\b", "KNIM<Know what I mean>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bL8R\b", "L8R<Later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bLD\b", "LD<Later dude / Long distance>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bLMAO\b", "LMAO<Laughing my a** off>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bLOL\b", "LOL<Laughing out loud>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bLTM\b", "LTM<Laugh to myself>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bLTNS\b", "LTNS<Long time no see>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bLYLAS\b", "LYLAS<Love you like a sis>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bM8\b", "M8<Mate>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bMoS\b", "MoS<Mother over shoulder>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bMUSM\b", "MUSM<Miss you so much>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bMYOB\b", "MYOB<Mind your own business>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bn00b\b", "n00b<Newbie>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNBD\b", "NBD<No big deal>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNFM\b", "NFM<None for me / Not for me>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNIMBY\b", "NIMBY<Not in my back yard>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNLT\b", "NLT<No later than>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNM\b", "NM<Nothing much / Never mind>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNMH\b", "NMH<Not much here>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNOYB\b", "NOYB<None of your business>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNP\b", "NP<No problem>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNRN\b", "NRN<No responce/reply necessary>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bNW\b", "NW<No way>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOIC\b", "OIC<Oh, I see>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOMG\b", "OMG<Oh my god>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOMW\b", "OMW<On my way>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOOTD\b", "OOTD<One of these days>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOP\b", "OP<On phone>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOTB\b", "OTB<Off to bed>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOTL\b", "OTL<Out to lunch>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOTOH\b", "OTOH<On the other hand>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOTTOMH\b", "OTTOMH<Off the top of my head>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bOTW\b", "OTW<Off to work>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPDQ\b", "PDQ<Pretty darn quick>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPITA\b", "PITA<Pain in the a**>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPLMK\b", "PLMK<Please let me know>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPLZ\b", "PLZ<Please>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPMFI\b", "PMFI<Pardon me for interrupting>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPMFJI\b", "PMFJI<Pardon me for jumping in>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPOAHF\b", "POAHF<Put on a happy face>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPOS\b", "POS<Parent over shoulder>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPPL\b", "PPL<People>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPRW\b", "PRW<People/parents are watching>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPTL\b", "PTL<Praise the Lord>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPXT\b", "PXT<Please explain this>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bPU\b", "PU<That stinks!>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bQIK\b", "QIK<Quick>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bRL\b", "RL<Real life>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bRME\b", "RME<Rolling my eyes>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bROTFL\b", "ROTFL<Rolling on the floor laughing>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bRSN\b", "RSN<Real soon now>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bRTFM\b", "RTFM<Read the f****** manual>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSICNR\b", "SICNR<Sorry, I could not resist>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSIG2R\b", "SIG2R<Sorry, I got to run>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSMHID\b", "SMHID<Scratching my head in disbelief>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSIS\b", "SIS<Snickering in silence>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSOMY\b", "SOMY<Sick of me yet?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSOTMG\b", "SOTMG<Short of time, must go>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSPK\b", "SPK<Speak>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSPST\b", "SPST<Same place, same time>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSRY\b", "SRY<Sorry>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSS\b", "SS<So sorry>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSSDD\b", "SSDD<Same stuff, different day>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSSINF\b", "SSINF<So stupid it's not funny>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSTR8\b", "STR8<Straight>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSTW\b", "STW<Search the Web)", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSUITM\b", "SUITM<See you in the morning>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSUL\b", "SUL<See you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSUP\b", "SUP<What's up?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bSYL\b", "SYL<See you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTA\b", "TA<Thanks alot>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTAFN\b", "TAFN<That's all for now>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTAM\b", "Tomorrow a.m.>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTBD\b", "TBD<To be determined>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTBH\b", "TBH<To be honest>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTC\b", "TC<Take care>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTGIF\b", "TGIF<Thank God it's Friday>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTHX\b", "THX<Thanks>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTIA\b", "TIA<Thanks in advance>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTIAD\b", "TIAD<Tomorrow is another day>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTLK2UL8R\b", "TLK2UL8R<Talk to you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTMI\b", "TMI<Too much information>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTMWFI\b", "TMWFI<Take my word for it>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTNSTAAFL\b", "TNSTAAFL<There's no such thing as a free lunch>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTPM\b", "TPM<Tomorrow p.m.>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTPTB\b", "TPTB<The powers that be>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTSTB\b", "TSTB<The sooner the better>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTTFN\b", "TTFN<Ta ta for now>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTTTT\b", "TTTT<These things take time>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTTYL\b", "TTYL<Talk to you later>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTTYS\b", "TTYS<Talk to you soon>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTU\b", "TU<Thank you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTY\b", "TY<Thank you>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTYT\b", "TYT<Take your time>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bTYVM\b", "TYVM<Thank you very much>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bUGTBK\b", "UGTBK<You've got to be kidding>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bUKTR\b", "UKTR<You know that's right>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bUL\b", "UL<Upload>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bUR\b", "UR<Your / You're>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bUV\b", "UV<Unpleasant visual>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bUW\b", "UW<You're welcome>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWAM\b", "WAM<Wait a minute>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWAN2TLK\b", "WAN2TLK<Want to talk>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWAYF\b", "WAYF<Where are you from?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bW/B\b", "W/B<Write back>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWB\b", "WB<Welcome back>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWIIFM\b", "WIIFM<What's in it for me?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWK\b", "WK<Week>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWKD\b", "WKD<Weekend>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWOMBAT\b", "WOMBAT<Waste of money, brains and time>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWRUD\b", "WRUD<What are you doing?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWTF\b", "WTF<What the f***?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWTG\b", "WTG<Way to go>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWTH\b", "WTH<What the heck?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWU\b", "WU?<What's up?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWUCIWUG\b", "WUCIWUG<What you see is what you get>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWUF\b", "WUF?<Where are you from?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWWJD\b", "WWJD<What would Jesus do?>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWWYC\b", "WWYC<Write when you can>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWYLEI\b", "WYLEI<When you least expect it>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bWYSIWYG\b", "WYSIWYG<What you see is what you get>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bYBS\b", "YBS<You'll be sorry>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bYGBKM\b", "YGBKM<You gotta be kidding me>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bYMMV\b", "YMMV<Your mileage may vary>", RegexOptions.IgnoreCase);
            message = Regex.Replace(message, @"\bYW\b", "YW<You're welcome>", RegexOptions.IgnoreCase);

            return message;
        }

        public string IDCreator(string type)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
            string fName = type + s;
            return fName;
        }

        public string BodyCreator(string sender, string subject, string message, string type)
        {
            if (type == "T")
            {
                string body = "Sender: @" + sender + " - Subject: " + subject + " - Message Text: " + message;
                return body;
            }
            if (type == "S")
            {
                string body = "Sender: " + sender + " - Message Text: " + message;
                return body;
            }
            if (type == "E")
            {
                string body = "Sender: " + sender + " - Subject: " + subject + " - Message Text: " + message;
                return body;
            }
            else
            {
                return "Message type was invalid";
            }
        }
    }
}
