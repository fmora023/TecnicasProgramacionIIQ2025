namespace ClassController
{
    public static class Examples
    {
        /// <summary>
        /// Sum the elements in the given list.
        /// </summary>
        /// <param name="elements">The elements.</param>
        /// <returns></returns>
        public static int ElementsSum(string elements)
        {
            var result = 0;

            var elementList = ParseStringAsList(elements);

            if (elementList.Count == 0)
            {
                return result;
            }
            else
            {
                foreach (var argument in elementList)
                {
                    result += argument;
                }
            }

            return result;
        }

        private static List<int> ParseStringAsList(string elements)
        {
            var result = new List<int>();
            if (string.IsNullOrWhiteSpace(elements))
            {
                return result;
            }

            var elementsArray = elements.Split(',');


            foreach (var element in elementsArray)
            {
                if (int.TryParse(element.Trim(), out var number))
                {
                    result.Add(number);
                }
            }

            /*var str = string.Empty;
            for (var i = 0; i <= elements.Length; i++)
            {
                if (i == elements.Length && str != ",")
                {
                    if (string.IsNullOrWhiteSpace(str))
                    {
                        continue;
                    }

                    result.Add(int.Parse(str.Trim()));
                }
                else if (elements[i] != ',')
                {
                    str += elements[i];
                }
                else if (elements[i] == ',')
                {
                    var couldCastElement = int.TryParse(str.Trim(), out var number);
                    if (!string.IsNullOrWhiteSpace(str) && couldCastElement)
                    {
                        result.Add(number);
                    }
                    str = string.Empty;
                }
            }*/

            return result;
        }
    }
}
