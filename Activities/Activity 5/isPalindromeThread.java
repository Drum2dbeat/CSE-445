package activity_5;

/*
 * Name:	Oscar Jara
 * Date:	1/25/19
 * Class:	CSE 445
 */

public class isPalindromeThread extends Thread{
	
	String str;
	String reverseStr;
	
	boolean isPalingdrome;
	
	public isPalindromeThread(String str) {
		isPalingdrome = false;
		this.str=str;
	}
	
	public void run() {
		checkPalindrome();
	}
	
	public void checkPalindrome() {
		reverseStr = new StringBuilder(str).reverse().toString();
		if (str.replaceAll("\\s", "").toLowerCase().equals(reverseStr.replaceAll("\\s","").toLowerCase()))
		isPalingdrome = true;
		else
			isPalingdrome = false;
	}
	
	public boolean isPalingdrome(){
		return isPalingdrome;
	}
	
}
