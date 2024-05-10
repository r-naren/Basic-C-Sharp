using System;
namespace LinqExcerice;
class Program
{
    public static void Main(string[] args)
    {
        TraineeData traineeDetails = new TraineeData();
        List<TraineeDetails> trainees = traineeDetails.GetTraineeDetails();
        string choice;
        do
        {
            Console.WriteLine(@"----------------------------------------------------------------------------------------------------------------------
                Press 1 to Show the list of Trainee Id
                Press 2 to Show the first 3 Trainee Id using Take
                Press 3 to show the last 2 Trainee Id using Skip
                Press 4 to show the count of Trainee
                Press 5 to show the Trainee Name who are all passed out 2019 or later
                Press 6 to show the Trainee Id and Trainee Name by alphabetic order of the trainee name.
                Press 7 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark
                Press 8 to show the unique passed out year using distinct
                Press 9 to show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message
                Press 10 to show the first Trainee Id and Trainee Name
                Press 11 to show the last Trainee Id and Trainee Name
                Press 12 to print the total score of each trainee
                Press 13 to show the maximum total score
                Press 14 to show the minimum total score
                Press 15 to show the average of total score
                Press 16 to show true or false if any one has the more than 40 score using any()
                Press 17 to show true of false if all of them has the more than 20 using all()
                Press 18 to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.
                Press 'N' for exit ");

            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            // Execute LINQ queries based on user input
            switch (choice)
            {
                case "1":
                    {
                        var traineeIds = trainees.Select(t => t.TraineeId); //select and print which properties needs to be fetched
                        foreach (var id in traineeIds)
                            Console.WriteLine(id);
                        break;
                    }

                case "2":
                    {
                        var first3Ids = trainees.Take(3).Select(t => t.TraineeId);
                        foreach (var id in first3Ids)
                            Console.WriteLine(id);
                        break;
                    }

                case "3":
                    {
                        var last2Ids = trainees.Skip(trainees.Count - 2).Select(t => t.TraineeId);
                        foreach (var id in last2Ids)
                            Console.WriteLine(id);
                        break;
                    }

                case "4":
                    {
                        Console.WriteLine(trainees.Count);
                        break;
                    }

                case "5":
                    var names2019OrLater = trainees.Where(t => t.YearPassedOut >= 2019).Select(t => t.TraineeName);
                    foreach (var name in names2019OrLater)
                        Console.WriteLine(name);
                    break;

                case "6":
                    var sortedNames = trainees.OrderBy(t => t.TraineeName).Select(t => new { t.TraineeId, t.TraineeName });
                    foreach (var trainee in sortedNames)
                        Console.WriteLine($"Id: {trainee.TraineeId}, Name: {trainee.TraineeName}");
                    break;

                case "7":
                    {
                        var highScorers = trainees.Where(t => t.ScoreDetails.Any(s => s.Mark >= 4))
                                               .Select(t => new { t.TraineeId, t.TraineeName, t.ScoreDetails });
                        foreach (var trainee in highScorers)
                        {
                            Console.WriteLine($"Trainee Id: {trainee.TraineeId}, Trainee Name: {trainee.TraineeName}");
                            foreach (var score in trainee.ScoreDetails)
                                Console.WriteLine($"Topic: {score.TopicName}, Exercise: {score.ExerciseName}, Mark: {score.Mark}");
                        }
                        break;
                    }

                case "8":
                    {
                        var uniqueYears = trainees.Select(t => t.YearPassedOut).Distinct();
                        foreach (var year in uniqueYears)
                            Console.WriteLine(year);
                        break;
                    }

                case "9":
                    {
                        Console.Write("Enter Trainee Id: ");
                        string traineeId = Console.ReadLine();
                        var traineeTotalScore = trainees.Where(t => t.TraineeId == traineeId)
                                                        .Select(t => t.TotalScore)
                                                        .FirstOrDefault();
                        if (traineeTotalScore != 0)
                            Console.WriteLine($"Total Score for Trainee {traineeId}: {traineeTotalScore}");
                        else
                            Console.WriteLine("Invalid Trainee Id");
                        break;
                    }

                case "10":
                    {
                        var firstTrainee = trainees.First();
                        Console.WriteLine($"Id: {firstTrainee.TraineeId}, Name: {firstTrainee.TraineeName}");
                        break;
                    }

                case "11":
                    {
                        var lastTrainee = trainees.Last();
                        Console.WriteLine($"Id: {lastTrainee.TraineeId}, Name: {lastTrainee.TraineeName}");
                        break;
                    }

                case "12":
                    {
                        foreach (var trainee in trainees)
                        {
                            Console.WriteLine($"Trainee Id: {trainee.TraineeId}, Total Score: {trainee.TotalScore}");
                        }
                        break;
                    }

                case "13":
                    {
                        var maxScore = trainees.Max(t => t.TotalScore);
                        Console.WriteLine($"Maximum Total Score: {maxScore}");
                        break;
                    }

                case "14":
                    {
                        var minScore = trainees.Min(t => t.TotalScore);
                        Console.WriteLine($"Minimum Total Score: {minScore}");
                        break;
                    }
                case "15":
                    {
                        var avgScore = trainees.Average(t => t.TotalScore);
                        Console.WriteLine($"Average Total Score: {avgScore}");
                    }
                    break;

                case "16":
                    {
                        bool anyScoreAbove40 = trainees.Any(trainee => trainee.ScoreDetails.Any(score => score.Mark > 40));
                        Console.WriteLine(anyScoreAbove40);
                        break;
                    }
                case "17":
                    {
                        bool allScoresAbove20 = trainees.All(trainee => trainee.ScoreDetails.All(score => score.Mark > 20));
                        Console.WriteLine(allScoresAbove20);
                        break;
                    }
                case "18":
                    {
                        var sortedTrainees = trainees.OrderByDescending(trainee => trainee.TraineeName)
                                                 .SelectMany(trainee => trainee.ScoreDetails
                                                                            .Select(score => new
                                                                            {
                                                                                trainee.TraineeId,
                                                                                trainee.TraineeName,
                                                                                score.TopicName,
                                                                                score.ExerciseName,
                                                                                score.Mark
                                                                            }))
                                                 .OrderByDescending(item => item.TraineeName);

                        foreach (var item in sortedTrainees)
                        {
                            Console.WriteLine($"Trainee ID: {item.TraineeId}, Trainee Name: {item.TraineeName}, Topic Name: {item.TopicName}, Exercise Name: {item.ExerciseName}, Mark: {item.Mark}");
                        }
                        break;
                    }
                case "N":
                    {
                        Console.WriteLine($"Exiting");
                        break;

                    }
                default:
                    {
                        Console.WriteLine($"Enter valid choice");
                        break;

                    }
            }
            Console.WriteLine($"Prese any key");

            Console.ReadKey();


        } while (choice.ToUpper() != "N");
        Console.WriteLine(traineeDetails);

    }
}