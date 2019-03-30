private void btnFindPalindromes_Click(object sender, EventArgs e)
        {        

            if (txtPalindrome.Text == "" && txtSizeOfPalindome.Text == "")
            {
                MessageBox.Show("Please enter a text sample and a palindrome size!");
            }
            else if (txtPalindrome.Text == "")
            {
                MessageBox.Show("You have not entered a text sample!");
            }
            else if (txtSizeOfPalindome.Text == "")
            {
                MessageBox.Show("You have not determine the size of the possible palindrome!");
            }
            else
            {
                Char[] characters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                  'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                                  'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                                  'u', 'v', 'w', 'x', 'y', 'z'};

                String text = txtPalindrome.Text;

                int size = int.Parse(txtSizeOfPalindome.Text);
                int length = text.Length;
                int x = 0;
                int count = 0;

                lstPalindromesFound.Items.Clear();

                text = text.ToLower();

                while (x <= length - 1)
                {
                    int checkCharacters = 0;

                    while (checkCharacters <= 35)
                    {
                        if (text[x].Equals(characters[checkCharacters]) == true)
                        {
                            break;
                        }
                        else
                        {
                            checkCharacters++;
                        }
                    }

                    if (checkCharacters == 36)
                    {
                        text = text.Remove(x, 1);
                        length = text.Length;
                        x--;
                    }
                    x++;
                }

                x = 0;

                while (x + size <= length)
                {
                    String subString1 = text.Substring(x, size);
                    int firstLetter = 0;
                    int z = 1;
                    int lastLetter = subString1.Length;

                    while (firstLetter <= lastLetter - z)
                    {
                        char first = subString1[firstLetter];
                        char last = subString1[lastLetter - z];

                        if (first == last && firstLetter == lastLetter - z)
                        {
                            subString1.ToUpper();
                            lstPalindromesFound.Items.Add(subString1);
                            count++;
                            firstLetter++;
                            z++;
                        }
                        else if (first == last)
                        {
                            firstLetter++;
                            z++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    x++;
                }
                MessageBox.Show("Your text included " + count + " palindrome(s)");
            }            
        }