# Online Python compiler (interpreter) to run Python online.
# Write Python 3 code in this online editor and run it.

def longest_substring_in_order(string):
    longest_subString = ''
    substring = ''
    for char in string:
        if(len(string) > 1):
            if (substring == ''):
                substring = char
            elif(substring[-1] == char):
                substring = char
            elif (substring[-1] < char):
                substring += char
            elif (substring[-1] > char):
                if (len(longest_subString) < len(substring)):
                    longest_subString = substring
                    substring = char
                else:
                    substring = char
        else:
            longest_subString = char
    if (len(substring) > len(longest_subString)):
        longest_subString = substring
    print(longest_subString)


string = 'acdkbarstyefgioprtyrtyx' #'a'#'aaa'  #'cyqfjhcclkbxpbojgkar'
longest_substring_in_order(string)
print("Hello world")