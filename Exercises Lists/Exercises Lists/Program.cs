namespace Exercises_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * 
             * 1- When you post a message on Facebook, depending on the number of people who like your post,
             * Facebook displays different information.
            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            Depending on the number of names provided, display a message based on the above pattern.
             */
            var friendsList = new List<string>();
            Console.WriteLine("Enter different names of your friends");
            while (true)
            {
                try
                {
                    var inputs = Console.ReadLine(); // keep collecting user inputs unless empty values
                    if (!string.IsNullOrEmpty(inputs))
                    {
                        // Split on both commas and spaces, and remove any empty entries
                        friendsList.AddRange(inputs.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));
                        /*friendsList.Add(inputs);*/
                    }
                    else // if empty value is supplied
                    {
                        if (friendsList.Count > 0)
                        {
                            if (friendsList.Count == 1)
                            {
                                Console.WriteLine($"[{friendsList[0]}] liked your post");
                                break;
                            }
                            if (friendsList.Count == 2)
                            {
                                Console.WriteLine($"[{friendsList[0]}] and [{friendsList[1]}] liked your post");
                                break;
                            }
                            
                            if (friendsList.Count > 2)
                            {
                                Console.WriteLine($"[{friendsList[0]}], [{friendsList[1]}] and [{friendsList.Count - 2} other] liked your post");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No one liked your post");
                            break;
                        }
                    }
                }
                catch (Exception ext)
                {

                    Console.WriteLine($"An error occurred: {ext}");
                    break;
                }
            }

        }
    }
}
