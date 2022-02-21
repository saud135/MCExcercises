
string = 'cyqfjhcclkbxpbojgkar'
longest_Substring = ''
substring = ''
for char in string:
    if (substring == ''):
        substring = char
    elif (substring[-1] <= char):
        substring += char
    elif (substring[-1] > char):
        if (len(longest_Substring) < len(substring)):
            longest_Substring = substring
            substring = char
        else:
            substring = char
if (len(substring) > len(longest_Substring)):
    longest_Substring = substring
print(longest_Substring)