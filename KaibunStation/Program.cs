using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaibunStation
{
    class Program
    {
        static readonly string[,] romaji = new string[,]
            {
                { "いぇ", "YE" },
                { "うぁ", "WHA" },
                { "うぃ", "WI" },
                { "うぇ", "WE" },
                { "うぉ", "WHO" },
                { "きぃ", "KYI" },
                { "きぇ", "KYE" },
                { "きゃ", "KYA" },
                { "きゅ", "KYU" },
                { "きょ", "KYO" },
                { "ぎぃ", "GYI" },
                { "ぎぇ", "GYE" },
                { "ぎゃ", "GYA" },
                { "ぎゅ", "GYU" },
                { "ぎょ", "GYO" },
                { "くぁ", "QA" },
                { "くぃ", "QI" },
                { "くぅ", "QWU" },
                { "くぇ", "QE" },
                { "くぉ", "QWO" },
                { "くゃ", "QYA" },
                { "くゅ", "QYU" },
                { "くょ", "QYO" },
                { "ぐぁ", "GWA" },
                { "ぐぃ", "GWI" },
                { "ぐぅ", "GWU" },
                { "ぐぇ", "GWE" },
                { "ぐぉ", "GWO" },
                { "しぃ", "SYI" },
                { "しぇ", "SHE" },
                { "しゃ", "SHA" },
                { "しゅ", "SHU" },
                { "しょ", "SHO" },
                { "じぃ", "JYI" },
                { "じぇ", "JE" },
                { "じゃ", "JA" },
                { "じゅ", "JU" },
                { "じょ", "JO" },
                { "すぁ", "SWA" },
                { "すぃ", "SWI" },
                { "すぅ", "SWU" },
                { "すぇ", "SWE" },
                { "すぉ", "SWO" },
                { "ちぃ", "CYI" },
                { "ちぇ", "CHE" },
                { "ちゃ", "CHA" },
                { "ちゅ", "CHU" },
                { "ちょ", "CHO" },
                { "ぢぃ", "DYI" },
                { "ぢぇ", "DYE" },
                { "ぢゃ", "DYA" },
                { "ぢゅ", "DYU" },
                { "ぢょ", "DYO" },
                { "つぁ", "TSA" },
                { "つぃ", "TSI" },
                { "つぇ", "TSE" },
                { "つぉ", "TSO" },
                { "てぃ", "THI" },
                { "てぇ", "THE" },
                { "てゃ", "THA" },
                { "てゅ", "THU" },
                { "てょ", "THO" },
                { "でぃ", "DHI" },
                { "でぇ", "DHE" },
                { "でゃ", "DHA" },
                { "でゅ", "DHU" },
                { "でょ", "DHO" },
                { "とぁ", "TWA" },
                { "とぃ", "TWI" },
                { "とぅ", "TWU" },
                { "とぇ", "TWE" },
                { "とぉ", "TWO" },
                { "どぁ", "DWA" },
                { "どぃ", "DWI" },
                { "どぅ", "DWU" },
                { "どぇ", "DWE" },
                { "どぉ", "DWO" },
                { "にぃ", "NYI" },
                { "にぇ", "NYE" },
                { "にゃ", "NYA" },
                { "にゅ", "NYU" },
                { "にょ", "NYO" },
                { "ひぃ", "HYI" },
                { "ひぇ", "HYE" },
                { "ひゃ", "HYA" },
                { "ひゅ", "HYU" },
                { "ひょ", "HYO" },
                { "びぃ", "BYI" },
                { "びぇ", "BYE" },
                { "びゃ", "BYA" },
                { "びゅ", "BYU" },
                { "びょ", "BYO" },
                { "ぴぃ", "PYI" },
                { "ぴぇ", "PYE" },
                { "ぴゃ", "PYA" },
                { "ぴゅ", "PYU" },
                { "ぴょ", "PYO" },
                { "ふぁ", "FA" },
                { "ふぃ", "FI" },
                { "ふぅ", "FWU" },
                { "ふぇ", "FE" },
                { "ふぉ", "FO" },
                { "ふゃ", "FYA" },
                { "ふゅ", "FYU" },
                { "ふょ", "FYO" },
                { "みぃ", "MYI" },
                { "みぇ", "MYE" },
                { "みゃ", "MYA" },
                { "みゅ", "MYU" },
                { "みょ", "MYO" },
                { "りぃ", "RYI" },
                { "りぇ", "RYE" },
                { "りゃ", "RYA" },
                { "りゅ", "RYU" },
                { "りょ", "RYO" },
                { "ヴぁ", "VA" },
                { "ヴぃ", "VI" },
                { "ヴぇ", "VE" },
                { "ヴぉ", "VO" },
                { "ヴゃ", "VYA" },
                { "ヴゅ", "VYU" },
                { "ヴょ", "VYO" },
                { "あ", "A" },
                { "い", "I" },
                { "う", "U" },
                { "え", "E" },
                { "お", "O" },
                { "か", "KA" },
                { "き", "KI" },
                { "く", "KU" },
                { "け", "KE" },
                { "こ", "KO" },
                { "が", "GA" },
                { "ぎ", "GI" },
                { "ぐ", "GU" },
                { "げ", "GE" },
                { "ご", "GO" },
                { "さ", "SA" },
                { "し", "SHI" },
                { "す", "SU" },
                { "せ", "SE" },
                { "そ", "SO" },
                { "ざ", "ZA" },
                { "じ", "JI" },
                { "ず", "ZU" },
                { "ぜ", "ZE" },
                { "ぞ", "ZO" },
                { "た", "TA" },
                { "ち", "CHI" },
                { "つ", "TSU" },
                { "て", "TE" },
                { "と", "TO" },
                { "だ", "DA" },
                { "ぢ", "JI" },
                { "づ", "ZU" },
                { "で", "DE" },
                { "ど", "DO" },
                { "な", "NA" },
                { "に", "NI" },
                { "ぬ", "NU" },
                { "ね", "NE" },
                { "の", "NO" },
                { "は", "HA" },
                { "ひ", "HI" },
                { "ふ", "HU" },
                { "へ", "HE" },
                { "ほ", "HO" },
                { "ば", "BA" },
                { "び", "BI" },
                { "ぶ", "BU" },
                { "べ", "BE" },
                { "ぼ", "BO" },
                { "ぱ", "PA" },
                { "ぴ", "PI" },
                { "ぷ", "PU" },
                { "ぺ", "PE" },
                { "ぽ", "PO" },
                { "ま", "MA" },
                { "み", "MI" },
                { "む", "MU" },
                { "め", "ME" },
                { "も", "MO" },
                { "や", "YA" },
                { "ゆ", "YU" },
                { "よ", "YO" },
                { "ら", "RA" },
                { "り", "RI" },
                { "る", "RU" },
                { "れ", "RE" },
                { "ろ", "RO" },
                { "わ", "WA" },
                { "ゐ", "WI" },
                { "ゑ", "WE" },
                { "を", "WO" },
                { "ぁ", "XA" },
                { "ぃ", "XI" },
                { "ぅ", "XU" },
                { "ぇ", "XE" },
                { "ぉ", "XO" },
                { "ヵ", "XKA" },
                { "ヶ", "XKE" },
                { "ゎ", "XWA" },
                { "ー", "-" }
            };

        static void Main(string[] args)
        {
            if(args.Length <= 0)
            {
                Console.WriteLine("sta_list.txtを指定してください。");
                return;
            }

            using (var cReader = (new System.IO.StreamReader(args[0], System.Text.Encoding.Default)))
            {
                int kanjicount = 0;
                int yomicount = 0;
                int romacount = 0;

                while (cReader.Peek() >= 0)
                {
                    var stBuffer = cReader.ReadLine();
                    var splitResult = stBuffer.Split('\t');

                    var kana = splitResult[1].Replace("・", "").Replace('ゔ', 'ヴ');

                    if (isKaibun(splitResult[0]) && splitResult[0].Length >= 2)
                    {
                        Console.WriteLine(string.Format("漢字が回文だよ! {0}駅（{1} / {2}）", splitResult[0], splitResult[1], splitResult[3]));
                        ++kanjicount;
                    }

                    if (isKaibun(kana))
                    {
                        Console.WriteLine(string.Format("読みが回文だよ! {0}駅（{1} / {2}）", splitResult[0], splitResult[1], splitResult[3]));
                        ++yomicount;
                    }

                    if(isKaibun(ToRomaji(kana)))
                    {
                        Console.WriteLine(string.Format("ローマ字が回文だよ! {0}駅（{1} / {2}）", splitResult[0], splitResult[1], splitResult[3]));
                        ++romacount;
                    }
                }

                Console.WriteLine("漢字が回文の駅は " + kanjicount + " 駅ありました。");
                Console.WriteLine("読みが回文の駅は " + yomicount + " 駅ありました。");
                Console.WriteLine("ローマ字が回文の駅は " + romacount + " 駅ありました。");
            }
        }

        static bool isKaibun(string str)
        {
            bool ret = true;
            for (int i = 0; i < str.Length; i++)
            {
                ret = ret && (str[i] == str[str.Length - 1 - i]);
                if (!ret)
                    break;
            }
            return ret;
        }

        static string ToRomaji(string str)
        {
            string ret = str.ToLower();
            int length = romaji.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                ret = ret.Replace(romaji[i, 0], romaji[i, 1]);
            }

            int p;
            while ((p = ret.IndexOf('ん')) != -1)
            {
                string orig = ret;
                if (ret.Length == p + 1 || "AIUEONY".IndexOf(ret[p + 1]) == -1)
                    ret = orig.Substring(0, p) + "N" + orig.Substring(p + 1);
                else
                    ret = orig.Substring(0, p) + "NN" + orig.Substring(p + 1);
            }

            while ((p = ret.IndexOf('っ')) != -1)
            {
                string orig = ret;
                if (ret.Length >= p + 2 && "AIUEON".IndexOf(ret[p + 1]) == -1 && char.IsUpper(ret[p + 1]))
                    ret = orig.Substring(0, p) + ret[p + 1] + orig.Substring(p + 1);
                else
                    ret = orig.Substring(0, p) + "XTU" + orig.Substring(p + 1);
            }

            ret = ret.ToUpper();

            if(!System.Text.RegularExpressions.Regex.IsMatch(ret, @"^[A-Z\-]*$"))
                Console.WriteLine("" + str + " -> " + ret);

            return ret;
        }
    }
}
