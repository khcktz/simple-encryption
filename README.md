# Simple AES Encryption Tool
This is a simple C# program that demonstrates symmetric encryption using the Advanced Encryption Standard (AES) algorithm. It allows users to encrypt and decrypt messages using a randomly generated key and initialization vector (IV).

## What Does This Program Do?
- Generates a Random Key and IV: The program creates a secure key and IV for AES encryption.

- Encrypts a Message: Users can input a plaintext message, and the program will encrypt it using AES.

- Decrypts a Message: The program can decrypt the encrypted message back to its original form using the same key and IV.

- Outputs Results: The program displays the generated key, IV, encrypted message (in Base64 format), and the decrypted message.

This tool is intended for educational purposes to help users understand the basics of symmetric encryption.

## How to Run the Program
### Prerequisites
- .NET SDK: Ensure you have the .NET SDK installed on your machine. You can download it from here.

- Code Editor: Use an IDE like Visual Studio, Visual Studio Code, or any text editor to view and run the code.

### Steps to Run
1. Clone or Download the Code:

- Clone this repository or download the .cs file to your local machine.

2. Open a Terminal:

- Navigate to the directory where the .cs file is located.

3. Compile and Run:

- Use the following commands to compile and run the program:

``` bash 
dotnet run
```

- If you're using Visual Studio, simply open the project and click the "Run" button.

4. Follow the Prompts:

- The program will prompt you to enter a message to encrypt. After encryption, it will display the encrypted and decrypted messages.

## Limitations
1. Educational Use Only:

- This tool is designed for educational purposes and should not be used to secure sensitive or real-world data. It lacks the robustness and security features required for production use.

2. Key Management:

- The program generates a random key and IV each time it runs. In a real-world scenario, secure key management is critical, and keys should never be hardcoded or stored insecurely.

3. No File Encryption:

- This program only encrypts and decrypts strings. It does not handle file encryption or other advanced use cases.

4. False Sense of Security:

- While AES is a secure encryption standard, this implementation is simplistic and does not include additional security measures (e.g., authentication, tamper detection, or secure key exchange).

5. Performance:

- This program is not optimized for performance and may not handle large inputs efficiently.

## Ethical Considerations and Responsible Use
### Intended Use
This tool is intended to help users learn about encryption concepts and how symmetric encryption works. It is suitable for:

- Students learning about cryptography.

- Developers exploring encryption in C#.

- Hobbyists interested in ethical hacking and cybersecurity.

### Potential for Misuse
While this tool is designed for educational purposes, it could potentially be misused. For example:

- Malicious Modifications: Someone could modify the program to encrypt files or data without the user's consent (e.g., ransomware).

- False Sense of Security: Users might mistakenly believe this tool is suitable for securing sensitive information, which it is not.

### Responsible Use Guidelines
- Do Not Use for Sensitive Data: This tool is not secure enough for real-world encryption tasks. Use industry-standard tools for securing sensitive information.

- Do Not Modify for Malicious Purposes: Do not alter this program to harm others or their data. Always use your skills ethically and responsibly.

- Educate Yourself: Use this tool as a starting point to learn more about encryption, cryptography, and cybersecurity best practices.

## Disclaimer
This program is provided as-is for educational purposes only. The author is not responsible for any misuse of this tool or any damages caused by its use. By using this program, you agree to use it responsibly and ethically.
