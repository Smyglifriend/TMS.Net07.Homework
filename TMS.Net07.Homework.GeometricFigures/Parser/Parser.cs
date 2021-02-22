using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.GeometricFigures
{
    public static class Parser
    {
        private static readonly Dictionary<string, string> DrawPatterns = new Dictionary<string, string>
        {
            ["rectangle"] = @"^drawrectangle\(\d+,\d+\)\(\d+,\d+\)$",
            ["square"] = @"^drawsquare\(\d+,\d+\)\(\d+,\d+\)$",
            ["triangle"] = @"^drawtriangle\(\d+,\d+\)\(\d+,\d+\)\(\d+,\d+\)$",
            ["circle"] = @"^drawcircle\(\d+,\d+\)\(\d+,\d+\)$",
            ["hexagon"] = @"^drawhexagon\(\d+,\d+\)\(\d+,\d+\)$"
        };

        public static /*List<Point>*/ Shapes Parse(string input)
        {
            foreach (var pattern in DrawPatterns)
            {
                if (Regex.IsMatch(input, pattern.Value))
                {
                    var numbers = ParseNumbers(input);
                    var points = new List<Point>();

                    for (var j = 0; j < numbers.Count; j += 2)
                    {
                        
                        points.Add(new Point(numbers[j], numbers[j + 1]));
                    }
                    //return points;
                    switch (pattern.Key)
                    {
                        case "rectangle":
                            return new Rectangle(points[0], points[1]);
                        case "square":
                            return new Square(points[0], points[1]);
                        case "triangle":
                            return new Triangle(points[0], points[1], points[3]);
                        case "circle":
                            return new Circle(points[0], points[1]);
                        case "hexagon":
                            return new Hexagon(points[0], points[1]);
                    }
                }
            }
            throw new ArgumentOutOfRangeException("You entered wrong count of points. Please check.");
        }
        private static List<int> ParseNumbers(string stringToParse)
        {
            return Regex.Matches(stringToParse, @"\d+")
                .Cast<Match>()
                .Select(x => int.Parse(x.Value))
                .ToList();
        }
    }
}
