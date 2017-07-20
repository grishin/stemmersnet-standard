/*
 *  Port of Snowball stemmers on C#
 *  Original stemmers can be found on http://snowball.tartarus.org
 *  Licence still BSD: http://snowball.tartarus.org/license.php
 *  
 *  Most of stemmers are ported from Java by Iveonik Systems ltd. (www.iveonik.com)
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Iveonik.Stemmers
{
    public class CzechStemmer : StemmerOperations, IStemmer
    {

        public string Stem(string input)
        {
            setCurrent(input.ToLowerInvariant());
            // stemming...
            //removes case endings from nouns and adjectives
            removeCase();
            //removes possesive endings from names -ov- and -in-
            removePossessives();
            //removes comparative endings
            removeComparative();
            //removes diminutive endings
            removeDiminutive();
            //removes augmentatives endings
            removeAugmentative();
            //removes derivational sufixes from nouns
            removeDerivational();

            //result = sb.toString();
            return getCurrent(); //sb.ToString();
        }

    }


}
