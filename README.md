challenge-calculator
Restaurant365 Code Challenge - String Calculator

Summary
Create a calculator that only supports an Add operation given a single formatted string

C# console application
Include unit tests
Provide code via a public distributed version control repository i.e. GitHub. Do NOT fork this repo
Show each step as a separate commit
Efficient code is always important but for this excercise readability and separation of concerns are much more critical
Not including one or more of the stretch goals will not affect your overall assessment but implementing them poorly will
Requirements
Support a maximum of 2 numbers using a comma delimiter. Throw an exception when more than 2 numbers are provided
examples: 20 will return 20; 1,5000 will return 5001; 4,-3 will return 1
empty input or missing numbers should be converted to 0
invalid numbers should be converted to 0 e.g. 5,tytyt will return 5
Remove the maximum constraint for numbers e.g. 1,2,3,4,5,6,7,8,9,10,11,12 will return 78
Support a newline character as an alternative delimiter e.g. 1\n2,3 will return 6
Deny negative numbers by throwing an exception that includes all of the negative numbers provided
Make any value greater than 1000 an invalid number e.g. 2,1001,6 will return 8
Support 1 custom delimiter of a single character using the format: //{delimiter}\n{numbers}
examples: //#\n2#5 will return 7; //,\n2,ff,100 will return 102
all previous formats should also be supported
Support 1 custom delimiter of any length using the format: //[{delimiter}]\n{numbers}
example: //[***]\n11***22***33 will return 66
all previous formats should also be supported
Support multiple delimiters of any length using the format: //[{delimiter1}][{delimiter2}]...\n{numbers}
example: //[*][!!][r9r]\n11r9r22*hh*33!!44 will return 110
all previous formats should also be supported
Stretch goals
Display the formula used to calculate the result e.g. 2,,4,rrrr,1001,6 will return 2+0+4+0+0+6 = 12
Allow the application to process entered entries until Ctrl+C is used
Allow the acceptance of arguments to define...
alternate delimiter in step #3
toggle whether to deny negative numbers in step #4
upper bound in step #5
Use DI
Support subtraction, multiplication, and division operations