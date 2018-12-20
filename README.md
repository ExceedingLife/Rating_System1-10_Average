# Rating_System1-10_Average
Console Application : Displays answers / averages / min and max answers.

1 Description
You are required to write a C# program that allows users to rate ﬁve social-consciousness 
issues from 1 (least important) to 10 (most important). Pick ﬁve causes that are important 
to you (for example, political issues, global environmental issues). 
Use a one-dimensional array named topics (of type String) to store the ﬁve causes. 
To summarize the survey responses, use a 5-row, 10-column two-dimensional array named responses (of type Integer), 
each row corresponding to an element in the topics array. When the program runs, it should ask 
the user to rate each issue. Have your friends and family respond to the survey. 
Then have the program display a summary of the results, including: 

a) A tabular report with the ﬁve topics down the left side and the 10 ratings across the top, 
listing in each column the number of ratings received for each topic. 
b) To the right of each row, show the average of the ratings for that issue. 
c) Which issue received the highest point total? Display both the issue and the point total. 
d) Which issue received the lowest point total? Display both the issue and the point total.

2 Grading
Grading Item Scores 
The program can be compiled without any error messages 10 
The program can be run without any error messages 10 
The program can display the tabular report correctly 30 
The program can display the average of the ratings for each issue correctly 10 
The program can display the issue received the highest point and the point total correctly 10 
The program can display the issue received the lowest point and the point total correctly 10 
Nice comments and proper indentations are used in the program 10 

3 Test Data and Output

The test data and sample output are listed as follows:

On a scale of 1-10, how important is global warming? 
> 8 
On a scale of 1-10, how important is the economy? 
> 10 
On a scale of 1-10, how important is war? 
> 9 
On a scale of 1-10, how important is health care? 
> 7 
On a scale of 1-10, how important is education? 
> 8 
Enter more data? (1=yes, 0=no): 1 
On a scale of 1-10, how important is global warming? 
> 2 
On a scale of 1-10, how important is the economy? 
> 4 
On a scale of 1-10, how important is war? 
> 8 
On a scale of 1-10, how important is health care? 
> 6 
On a scale of 1-10, how important is education? 
> 9 
Enter more data? (1=yes, 0=no): 1 
On a scale of 1-10, how important is global warming?

Topic 		        1 2 3 4 5 6 7 8 9 10 	Average 
global warming    1 1 1 0 0 0 0 1 0 1 	4.8 
the economy 	    0 2 0 1 0 0 1 0 0 1 	5.0 
war 		          0 0 2 0 1 0 0 1 1 0 	5.6 
health care 	    0 0 0 1 0 3 1 0 0 0 	5.8 
education 	      0 0 0 0 1 0 0 2 2 0 	7.8 
Highest points: 	 education (39) 
Lowest points:	   global warming (24)
