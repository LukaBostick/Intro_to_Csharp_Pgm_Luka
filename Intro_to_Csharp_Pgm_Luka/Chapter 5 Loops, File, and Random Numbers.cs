
namespace Chapter5LoopsFileandRandomNumbers
{
	class Test
	{
		static void Main(string[] args)
		{

		}
	}
}

/* /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				Chapter 5 Loops, Files and Random Numbers
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *							Topics
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	*5.1 More about ListBoxes
 *	
 *	*5.2 The while Loop
 *	
 *	*5.3 The ++ and -- operators
 *	
 *	*5.4 The for Loop
 *	
 *	*5.5 The do-while Loop
 *	
 *	*5.6 Using Files for Data Storage
 *	
 *	*5.7 The OpenFIleDialog and SaveFileDialog Controls
 *	
 *	*5.8 Random Numbers
 *	
 *	*5.9 The Load Event
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *				5.1 More about ListBoxes
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *		Concept ListBox controls have various methods and properties that
 *		you can use in code to manipulate the ListBox's contents.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In Chapter 4, we introduced the ListBox control, which displays a 
 * list of items and allows the user to select one or more items from the
 * list. In this chapter, we will use ListBox controls to display output.
 * Many of the algorithms that you will see in this chapter generate lists
 * of data and then display those lists in ListBox controls.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Recall from Chapter 4 that you add items to a ListBox control's Items
 * property, and those are displayed in the ListBox. At design time, you
 * can use the Properties window to add items to the control's Item
 * property. You can also write code that adds items to a ListBox control
 * at run time. To add an item to a ListBox control with code, you call the
 * control's Items.Add method. Here is the method's general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					ListBoxNames.Add(Item);
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ListBoxName is the name of ListBox control. Item is the value to be 
 * added to the Items property. For example, in the Chap05 folder of 
 * this book's Student Sample Programs, you will find a project named
 * Name List. Figure 5-1 shows the application's form at run time. As 
 * shown in the image on the left, the ListBox's name is nameListBox and
 * the Button control's name is addButton. At run time, when you click
 * the addButton control, the names shown in the image on the right are
 * added to the nameListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-1 The Name List application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  Here is the code for the addButton_Click event handler:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void addButton_Click(object sender, EventArgs e)
 * {
 *		namesListBoxes.Items.Add("Chris");
 *		namesListBoxes.Items.Add("Alicia");
 *		namesListBoxes.Items.Add("Justin");
 *		namesListBoxes.Items.Add("Holly");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You can add values of other types as well. In the chap5 folder 
 * of the book's Student Sample Program, you will find a project named
 * Number List. Figure 5-2 shows the application's form. As shown in the 
 * image on the left, the ListBox's name is numberListBox and the Button
 * control's name is addButton. At run time, when you click the addButton
 * control, the numbers shows in the image on the right are added to the 
 * numberListBox control.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *				Figure 5-2 The Number List application 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the code for addButton_CLick event handler:
 * 
 * private void addButton_Click(object sender, EventArgs e)
 * {
 *		namesListBoxes.Items.Add(10);
 *		namesListBoxes.Items.Add(20);
 *		namesListBoxes.Items.Add(30);
 *		namesListBoxes.Items.Add(40);
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					The Items.Count Property
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ListBox controls have an Items.Count property that reports the number
 * of items stored in the ListBox. If the ListBox is empty, the Items.
 * Count property equals 0. For example, assume an application has a 
 * ListBox control named employeesListBox. The following if statement
 * displays a message box if there are no items in the ListBox:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * if(employeesListBox.Items.Count == 0)
 * {
 *		MessageBox.Show("There are no items in the list!");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Items.Count property haolds an integer value. Assuming
 * numEmployees is an int variable, the following statement assigns the 
 * number of items in the employeesListBox to the numEmployees variable:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	numEmployees = employeesListBox.Items.Count;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The Items.Clear Method
 * /////////////////////////////////////////////////////////////////////
 * ListBox controls have an Items.Clear method that erases all the items
 * in the property. Here is the method's general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ListBoxName.Items.Clear();
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * For example, assume an application has a ListBox control named 
 * employeesListBox. The following statement clears all the items in the
 * list:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * employeesListBox.Items.Clear();
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *						5.2 The while Loop
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: The while loop causes a statement or a set of statements to
 * repeat as long as a Boolean expression is true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The while loop gets its name from the way it works: While a Boolean
 * expression is true, do some task. 
 * The loop has two parts:(1) a Boolean expression that is tested for a 
 * true or false value and (2) a statement or set of statements that is 
 * repeated as long as the Boolean expression is true. Figure 5-3 shows
 * the logic of a while loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-3 The logic of a while loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The diamond symbol represents the Boolean expression that is tested.
 * Notice what happens if the expression is true: one or more statements 
 * are executed and the program's execution flows back to the point just
 * above the diamond symbol. The Bollean expression is tesed again, and 
 * if it is true, the preocess repeats. If the Boolean expression is false,
 * the program exits the loop. Each time the loop executes its statement 
 * or statements, we say the loop is iterating, or preforming an iteration
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the general format of the while loop:
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(Boolean Expression)
 * {
 *		statement;
 *		statement;
 *		etc.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We refer to the first line as the while clause. The while clause begins
 * with the word while, followed by a Boolean expression that is enclosed 
 * in parentheses. Beginning on the next line is a set of statements 
 * enclosed in curly braces. THis block od statements is known as the
 * body of the loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When the while loop executes, the Boolean expression is tested. If 
 * the Boolean expression is true, the statements that appear in the 
 * body of the loop are executed, and then the loop starts over. If the
 * Boolean expression is false, the loop ends and the program resumes
 * execution at the statement immediately following the loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We say that the statements in the body of the loop are conditionally
 * executed because they are executed only under the condition that the 
 * Boolean expression is true. if you are writing a while loop that has 
 * only one statement in its body, you do not have to enclose the
 * statement  inside curly braces. Such a loop can be written in the 
 * following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(BooleanExpression)
 *	statement;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a while loop written in this format executes, the Boolean
 * expression is tested. If it is true, the one statement that appears
 * on the next line is executed, and then the loop starts over. IF the 
 * Boolean expression if false, however, the loop ends.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Althought the curly braces are not required when there is only one 
 * statement in the loop's body, it is still a good idea to use them,
 * as shown in the following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * while(BooleanExpression)
 * {
 *		statement;
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When we discussed the various if statements in Chapter 4, we mentioned
 * that this is a good style of programming because it cuts down on errors.
 * 
 * IF you have more than one statement in the body of a loop, those
 * statements must be enclosed in curly braces. IF you get into the habit
 * of always enclosing the conditionally executed statements in a set of 
 * curly braces, it's less likely that you will forget them.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * You should also notice that the statments in the body of the loop
 * are indented. As with if statements, the indentation makes the code 
 * easier to read and debug. By indenting the statements in the body
 * of the loop, you visually set them apart from the surronding code.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at an example. In the CHap 5 folder of this book's Student
 * Sample Programs, you will find a project named while Loop Demo. Figure
 * 5-4 shows the application's form at run time. As shown in the image
 * on the left, the Button control's name is goButton. At run time, when 
 * you click the goButton control, the message box shown in the image on 
 * the right is displayed. When you click the OK button to close the 
 * message box, another identical message bos is displayed. The message
 * box is displayed a total of five times.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-4 The while Loop Demo application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Were is the code for the goButton_Click event handler:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *		// Declare a variable to count the loop iterations.
 *		int count = 1;
 *		
 *		// Display "Hello" in a message box five times.
 *		
 *		while(count <= 5)
 *		{
 *			//Display the message box.
 *			MessageBox.Show("Hello");
 *			
 *			// Add one to count.
 *			count = count + 1;
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a closer look at this code. In line 4 an int variable 
 * named count is declared and initialized with the value 1. A while loop
 * begins in line 7. Notice that the while loop tests the expression
 * count <= 5. The statementes in the body of the while loop repeat as 
 * long as the count variable is less than or equal to 5. Inside the body
 * of the loop, line 10 displays "Hello" in a message box, and then line
 * 13 adds one to the count variable. This is the last statement in the
 * body of the loop, so after it executes, the loop starts over. IT tests
 * the Boolean expression again, and if it is true, the statements in the 
 * body of the loop are executed. This cycle repeats until the Boolean
 * expression count <=5 is false, as illustrated in Figure 5-5. A 
 * flowchart for the loops is shown in Figure 5-6.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-5 The while Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-6 Flowchart for the while Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The while Loop Is a Pretest Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The while loop is known as a pretest loop, which means it tests its
 * condition before performing an iteration. Because the test is done at
 * the beginning of the loop, you usually have to perform some steps
 * prior to the loop to make sure that the loop executes at least once.
 * Notice the declarations of the count variable in the while loop Demo 
 * program:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * int count = 1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The count variable is initialized with the value 1. If count had been
 * initialized with a value that is greater than 5, as shown in the 
 * following program sample, the loop would never execute:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *		// Declare a variable to count the loop iterations.
 *		int count = 6;
 *		
 *		// Display "Hello" in a message box five times.
 *		
 *		while(count <= 5)
 *		{
 *			//Display the message box.
 *			MessageBox.Show("Hello");
 *			
 *			// Add one to count.
 *			count = count + 1;
 *		}
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * An important characteristic of the while loop is that the loop will 
 * never iterate if the Boolean expression is false to start with. If you
 * want to be sure that a while loop executes the first time, you must
 * initialize the relevant data in such a way that the Boolean expression
 * starts out true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *	Counter Variables
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the while Loop Demo application, the variable count is initialized
 * with the value 1, and then 1 is added to the variable count during 
 * each loop iteration. The loop executes as long as count is less than
 * or equal to 5. The variable count is used as a counter variable, which
 * means it is regularly incremented in each loop iteration. In essence,
 * the count variable keeps count of the number of iterations of the 
 * loop performed. Counter variables are commonly used to control the 
 * number of times that a loop iterates.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-1 will give you some practive writing a loop and using 
 * a counter variable. In the tutorial, you will write a while loop that 
 * calculates the amount of interest earned by a bank account each month
 * for a number of months.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-1: Using a Loop to Calculate an Account Balance
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you complete the Ending Balance application. The 
 * project has already been started for you and is located in the Chap05
 * folder of this book's Student Sample Programs.
 * The application's form is shown in Figure 5-7
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-7 The Ending Balance form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you complete the application, it will allow the user to enter an
 * account's starting balance into the startingBalTextBox control and the
 * number of months that the account will be left to earn interest into
 * the monthsTextBox control. When the user clicks the calculateButton
 * control, the application calculates the account's balance at the end
 * of the time period. The account's monthly interest rate is 0.005 and 
 * the interest is compounded monthly.
 * 
 * Step 1: Start Visual Studio. Open the project named Ending Balance in
 * the Chap05 folder of this book's Student Sample Programs.
 * 
 * Step 2: Open the Form1 form in the Designer. The form is shown, along
 * with the names of the important controls, in Figure 5-7.
 * 
 * Step 3:Now you will create the Click event handlers for the Button 
 * controls. At the end of this tutoral, Program 5-1 shows the 
 * completed code for the form. you will be instructed to refer to 
 * Program 5-1 as you write the event handlers.
 * 
 * In the Designer, double-click the calculateButton control. This opens
 * the code editor, and you will see an empty event handler named
 * calculateButton_Click. Complete the calculateButton_Click event
 * handler by typing the code shown in lines 22-59 in Programs 5-1.
 * 
 * Let's take a closer look at the code:
 * 
 * Line 23: This statement declares a constant decimal named 
 * INTEREST_RATE, set to the value 0.005. THis is the monthly interest
 * rate.
 * 
 * Lines 26-28: These statements declare the following variables:
 *		* balance, a decimal variable to hold the account balance.
 *		
 *		* months, an int variable to hold the number of months that the 
 *		  account will be left to earn intrest.
 *		
 *		* count, an int that is used to count the months as as a loop
 *		  iterates. Notice that the count variable is initialied with
 *		  the value 1.
 *		  
 * Line 31: This if statement tries to convert startingBalTextBox.Text to
 *			a decimal. If the conversion is successful, the result is 
 *			stored in the balance variable, and the program continues
 *			executing at line 33. If the conversion is not successful, 
 *			the program jumps to the else clause in line 55, and line 58
 *			displays the error messsage invalid value for starting 
 *			balance.
 *			
 * Line 34: This if statement tries to convert monthsTextBox.Text to an
 * int. IF the conversion is successful, the result is stored in the 
 * months variable, and the program continues executing at line 36. If 
 * the conversion is not successful, the program jumps to the else clause
 * in line 49, and line 52 displays the error message invalid value for
 * months.
 * 
 * Line 37: This is the beginning of a while loop. The loop executes as
 * long as the expression count <= months is true.
 * 
 * Lines 39-43: These statements are the body of the loop. Line 40 
 * calculates the monthly interest and adds it to the balance variable.
 * Line 43 adds 1 to the count variable.
 * 
 * Line 47: This statement executes after the loop has finished all of 
 * its iterations. It converts the value of the balance variable to a
 * string (formatted as currency) and assigns the resulting string to
 * the endingBalanceLabel control's Text property.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 4: Switch your view back to the Designer and double-click the
 * clearButton control. In the code editor you will see an empty event
 * handler named clearButton_Click. Complete the clearButton_Click event
 * handler by typing the code shown in lines 64-70 in Program 5-1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 5: Switch your view back to the Designer and double-click the 
 * exitButton control. In the code editor you will see an empty event
 * handler named exitButton_CLick. Complete the exitButton_Click event
 * handler by typing the code shown in lines 75-76 in Program 5-1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 6: Save the project. Then, press f5 on the keyboard, or click
 * the Start Debugging button(|>) on the toolbar to compile and run the 
 * application. First, enter 1000 as the starting balance and 48 as the 
 * number of months. Click the Calculate Average button and $1,270.49
 * should appear as the ending balance. Think about the value that you 
 * entered for the number of months. How many times did the while loop
 * in line 36 iterate? (Answer: 48 times.)
 * 
 * Next click the Clear button to clear the TextBoxes and the ending
 * balance. How many times did the while loop iterate this time?
 * (Answer: 1 time.) Continue to test the application as you wish.
 * When you finished, click the Exit button and the form should close.
 * 
 * (IF you plan to continue to the next tutorial, leave this project open
 * in Visual Studio.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Tutorial 5-2: Enhancing the Ending Balance Application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this tutorial, you enhance the Ending Balance application that
 * you created in Tutorial 5-1. First, add a ListBox control to the 
 * application's form, as shown in Figure 5-8. Then modify the
 * calculateButton_Click event handler so it displays each month's ending
 * balance in the ListBox. Figure 5-9 shows as example of how the form will
 * appear at run time, when the user has entered 1000 for the starting
 * balance and 8 for the months.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-8 The modified Ending Balance form
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-9 Example output
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Step 1: Start Visual Studio and open the Ending Balance project that
 * you completed in Tutotial 5-1.
 * 
 * Step 2: Enlarge the form so it is roughly the size shown in Figure
 * 5-8. (310 x 325.)
 * 
 * Step 3: Create a ListBox control named detailListBox. Resize the 
 * ListBox as shown in Figure 5-8.
 * 
 * Step 4:Switch to the code editor and insert the code shown in lines
 * 42-45 in Program 5-2.) (The new lines of code are shown in bold.) The
 * statement in lines 43-45 adds a string to the detailListBox control.
 * If you examine the statement carefully, you will see that is uses 
 * concatenation to create a string in the following format:
 * The ending balance for month count is balance.
 * IN the actual string that is created, count will be the value of the 
 * count variable and balance will be the value of the balance variable,
 * formatted as currency.
 * 
 * Step 5:Find the clearButton_Click event handler in the code editor. 
 * Update the comment as shown in lines 69-70, and insert the line of
 * code shown in line 74. (The lines are shown in bold.) The statement in
 * line 74 clears the contents of the detailListBox control.
 * 
 * Step 6: Save the project. Then, press F5 on the keyBoard or click the 
 * Start Debugging button(|>) on the toolbar to compile and run the
 * application. As shown in Figure 5-9, enter 1000 as the starting 
 * balance and 8 as the number of months. Click the Calculate Average
 * button. Your output should look like that shown in Figure 5-9. Click
 * the Clear button and enter any other values you wish to test the 
 * application further. When you are finished, click the Exit button and
 * the form should close.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *							Infinite Loops
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In all but rare cases, loops must contain a way to terminate within
 * themselves. This means that something inside the loop must eventually
 * make the loop's Boolean expression false. The loop in Program 5-2
 * stops when the expression count <= months is false. 
 * 
 * If a loop does not have a way of stopping, it is called an infinite loop.
 * An infinite loop continues to repeat until the program is interrupted.
 * Infinite loops usually occur when the programmer forgets to write code
 * inside the loop that makes the test condition false.
 * In most circumstances, you should avoid writing infinite loops.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The following code sample demonstrates an infinite loop. In line 1, 
 * the count variable is declared and initialied with the value 1.
 * The while loop that begins in line 5 executes as long as count is less
 * than or equal to 5. There is no code inside the loop to change the 
 * count variable's value, so the expression count <= 5 in line 5 is
 * always true. As a consequence, the loop has no way of stopping.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * / /Declare a variable to count the loop iterations 
 * int count = 1;
 * 
 * / / How mant times will this loop iterate?
 * 
 * while(count <= 5)
 * {
 *	/ / Display the message box.
 *	MessageBox.Show("Hello");
 * }
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *						5.3 The ++ and -- operators
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: To increment a variable means to increase its value, and to
 * decrement a variable means to decrease its value. C# provides special
 * operators to increment and decrement variables.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * To increment a variable means to increase its value and to decrement
 * a variable means to decrease its value.
 * 
 * Both of the following statements increment the variable num by 1:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num = num + 1;
 * num += 1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * And num is decremented by 1 in both the following statements:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num = num - 1;
 * num -= 1;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Incrementing and decrementing is so commonly done in programs that C#
 * provides a set of simple unary operators designed just for
 * incrementing and decrementing variables. The increment operator is ++,
 * and the decrement ioerator is --. The following statement uses the ++
 * operator to add 1 to num:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num++;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * After this statement executes, the value of num is increased by 1. 
 * The following statement uses the -- operator to subtract 1 from num:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * num--;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Note: The ++ operator is pronounced "plus plus," and the -- operator
 * is pronounced "minus minus." THe expression num++ is pronounced
 * "num plus plus", and the expression num-- is pronounced
 * "num minus minus."
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In these examples, we have written the ++ and -- operators after their
 * operands (or, on the right side of their operands). This is called 
 * postfix mode. The operators can also be written before (or, on the 
 * left side) of their operands, which is called prefix mode. Here are
 * examples:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * ++num;
 * --num;
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When you write a simple statement to increment or decrement
 * a variable, such as the ones shown here, it doesn't matter if you use
 * prefix mode or postfix mode. The operators do the same thing in either
 * mode; however, if you write statements that mix these operators with 
 * other operators or with other operations or with other operations, 
 * there is a difference in the way the two modes work. Such complex
 * code can be difficult to understand and debug. When we use the 
 * increment and decrement operators, we will do so only in ways that are
 * straightforwars and easy to understand, such as the statements
 * previously shown. 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * We introduce these operators at this point because they are commonly
 * used in loops. THe following code segment shows an example.
 * In the code, the count variable is initialized with the value 1. The
 * while loop that begins in line 5 iterates as long as count is less 
 * than or equal to 5. The statement in line 11 increments count. The
 * loop will iterate 5 times.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *  // DEclare a variable to count the loop iterations.
 *  int count = 1;
 *  
 *  // Display "Hello" in a message box five times.
 *  while(count <= 5)
 *  {
 *		// Display the message box.
 *		MessageBox.Show("HEllo");
 *		
 *		// Increment count.
 *		count++;
 *  }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the next section, which discusses the for loop, you will see
 * these operators used often.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 *							5.4 The for Loop
 * /////////////////////////////////////////////////////////////////////
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Concept: The for loop is ideal for performing a know number of
 * iterations.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The for loop is specifically designed for situations requiring a
 * counter variable to control the number of tiems that a loop iterates.
 * When you write a for loop, you specify three actions:
 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Initialization: This action take place when the loop begins. It
 * Happens only once.
 * 
 * *Test: A Boolean expression is tested. IF the expression is true, the
 * loop iterates. Otherwise, the loop stops.
 * 
 * *Update: This action takes place at the end of each loop iteration.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-10 shows how these three actions are used in the logic of a 
 * for loop.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-10 Logic of a for loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the general format of the for loop:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(InitializationExpression; TestExpression; UpdateExpression)
 * {
 *		statement;
 *		statement;
 *		etc.
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The statements that appear inside the curly braces are the body of 
 * the loop. These are the statements that are executed each time the 
 * loop iterates. As with other control structures, the curly braces are
 * optional if the body of the loop contains only one statement, as 
 * shown in the following general format:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(InitializationExpression; TestExpression; UpdateExpression
 * statement;)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first line of the for loop is the loop header. After the key word
 * for, there are three expressions inside the parentheses, separated by
 * semicolons. (Notice that there is not a semicolon after the third 
 * expression.)
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * The first expression is the initialization expression. IT is normally
 * used to initialize a counter variable to its starting value. This is 
 * the first action performed by the loop, ans it is only done once.
 * The second expression is the test expression. This is a Boolean 
 * expression that controls the execution of the loop. As long as the 
 * expression is true, the body of the for loop will repeat. The for
 * loop is a pretest loop, as it evaluates the test expressiomn before 
 * each iteration. The third expression is the update expression, IT 
 * executes at the end of each iteration. Typically, this is a statement
 * that increments the loop's counter variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's assume that count is an int variable that has already been 
 * declared. Here is an example of a simple for loop that displays
 * "Hello" in a message box 5 times:
 * ////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for(count = 1; count <= 5; count++)
 * {
 *		MessageBox.Show("Hello");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this loop, the initialization expression is count = 1, the test 
 * expression is count <= 5, and the increment expression is ccount++.
 * The body of the loop has one statement, which is the call to
 * MEssage.Show method. This is a summary of what happens when this loop
 * executes:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 1. The initialization expression count = 1 is executed. This assigns
 * 1 to the count variable.
 * 
 * 2. The expression count <= 5 is tested. If the expression is true, 
 * continue which Step 3. Otherwise, the loop is finished.
 * 
 * 3. The statemetn MEssageBox.Show("Hello"); is executed.
 * 
 * 4. The update expression count++ is executed.
 * This adds 1 to the count variable.
 * 
 * 5. Go back to Step 2.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-11 illustrates this sequence of events. Notice that Steps
 * 2-4 are repeated as long as the test expression is true.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-12 shows the logic of the loop as a flowchart.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-11 Sequence of events in the for loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-12 Logic of the for loop 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's look at a complete application that uses a for loop. IN the 
 * Chap05 fold of this book's Student Programs, you will find a project
 * named Squares.
 * 
 * The purpose of the the application is to display the numbers 1-10
 * and their sequares. Figure 5-13 shows the application's form at run 
 * time. As shown in the image on the left, the ListBox's name is
 * outputListBox and the Buton control's name is goButton. At run
 * time, when you click the goButton control, the outputListBox control
 * displays the program's output, as shown in the image on the right.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Figure 5-13 The Seqares application
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Here is the code for the goButton_Click event handler:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * private void goButton_Click(object sender, EventArgs e)
 * {
 *		// Contrant for the maximum number
 *		
 *		const int MAX_VALUE = 10;
 *		
 *		// Loop counter
 *		int number;
 *		
 *		// Display the list of number and their squares.
 *		for(number = 1; number <= MAX_VALUE; number++)
 *		{
 *		
 *		// yay we have are first cool code optimization!
 *		
 *		// it is faster, if you a variable in scope, to 
 *		multiply the local variable by it's self
 *		instead of using pow() method.
 *		
 *		outputListBox.Items.Add("The seqare of "
 *		+number + " is " + (number * number));
 *		}
 * 
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Let's take a close look at the code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * *Line 4 declares an int constant named MAX_VALUE, set to the value 10.
 *   This is the maximum number that we will use to calculate a square.
 *   
 * *Line 7 declares an int variable named number. This variable is used
 * both as a counter variable and in the calculation of squares.
 * 
 * *Line 10 is the beginning of a for loop. You can see form this line that
 * the loop works in the following way:
 *		
 *		Initialiation: The number variable is initialized with the value 1.
 *		
 *		Test: The expression number <= MAX_VALUE is tested at the begginning of each iteration.
 *		
 *		Update: The expression number++ is executed at the end of each iteration.
 *		
 *	*Since the MAX_VALUE constant is set to the value 10, the number variable will
 *	be assigned the values 1 through 10 as the loop iterates.
 *	
 *	*Lines 13 and 13: This statement adds a line to the ListBox showing the current
 *	value of the number variable, and the square of that value.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					The for Loop Is a Pretest Loop
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because the for loop tests its Boolean expression before it preforms
 * an itertion, is a pretest loop. it is a pretest loop. IT is possible 
 * to write a for loop in such a way that it will never iterate. Here is
 * an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Because the variable count is initialized to a value that makes the
 * Boolean expression false form the beginning, this loop terminates as 
 * soon as it begins.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Declaring the Counter Variable in the Initialization Expression
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Not only may the counter variable be initialized in the initialization
 * expression, but it may also be declared there.
 * The following code shows an example:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for (int count = 1; count <= 5; count++)
 * {
 *	MessageBox.Show("Hello");
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In this loop, the count variable is both declared and initialized in
 * the initialization expression. If the variable is used only in the 
 * loop, it makes sense to define it in the loop header. This makes the
 * variable's purpose clearer.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * When a variable is declared in the initializaed expression of a for
 * loop, the scope of the variable is limited to the loop. This means 
 * you cannot access the variable in statements outside the loop. For 
 * example, the following code would caise a compiler error bacause the 
 * statement in line 6 cannot access the count variable.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 *					Other Forms of the Update Expression
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * In the update expression, the counter variable is typically incremented 
 * by 1. This makes it convenient to use the ++ operator in the increment
 * expression. This is not a requirement, however. You can write virtually
 * any expression you wish as the update expression.
 * For example, the following loop increments count by 10:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for (int count = 0; count <= 100; count += 10)
 * {
 *	MessageBox.Show(count,ToString());
 * }
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Notice that in this example the increment expression is count+= 10.
 * This means that at the end of each iteration, 10 is added to count.
 * During the first iteration count set to 0, during the second iteration
 * count is set to 10, during the third iteration count is set to 20, and
 * so forth.
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Counting Backward by Decrementing the Count Variable
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * Although the counter variable is usually incremented in a
 * count-controlled loop, you can alternatively decrement the counter
 * variable.
 * 
 * For example, loop at the following code:
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * for (int count = 10; count >= 0; count--)
 * {
 *	MessageBox.Show(count.ToString());
 * }
 * MessageBox.Show("Blastoff!");
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * IN this loop, the count variable is initialized with the value 10. 
 * The loop iterates as ling as count is greater than or equal to 0.
 * At the end of each iteration, count is decremented by 1.
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * During the first iteration count is 10, during the second iteration
 * count is 9, and so forth
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////
 * 
 * /////////////////////////////////////////////////////////////////////

 * /////////////////////////////////////////////////////////////////////
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */