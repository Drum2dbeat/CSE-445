package activity_5;

import java.util.*;
import java.util.Scanner;

/*
 * Name:	Oscar Jara
 * Date:	1/25/19
 * Class:	CSE 445
 */

public class Analyze_String {

	static Scanner scan = new Scanner(System.in);
	
	public static void main(String[] args) {
		
		System.out.println("Please Enter a String!");
		System.out.println("======================");
		String str = scan.nextLine();
		System.out.println("======================" + "\n");
		
		DigitalCountThread t1 = new DigitalCountThread(str);
		isPalindromeThread t2 = new isPalindromeThread(str);
		upperCountThread t3 = new upperCountThread(str); 
		t1.start();
		t2.start();
		t3.start();
		
		try {
			t1.join();
			t2.join();
			t3.join();
		} catch (InterruptedException e) {
			
			e.printStackTrace();
		}
		int count = t1.getCount();
		boolean palindrome = t2.isPalingdrome();
		int upperCount = t3.getUpperCount(); 
		
		System.out.println("Information Details:");
		System.out.println("---------------------");
		System.out.println("Number of Digits: "+ count);
		if(palindrome)
			System.out.println("Input is a Palindrome");
		else
			System.out.println("Input is not a Palindrome");
		
		System.out.println("Number of Upper Case Letters: "+ upperCount);	
	}

}
