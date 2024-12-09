

import re

def extract_phone_numbers(vcf_file):
    with open(vcf_file, 'r', encoding='utf-8') as file:
        content = file.read()
    
    pattern = r'TEL[^:]*:([\+\d\s-]+)'
    phone_numbers = re.findall(pattern, content)
    
    cleaned_numbers = [re.sub(r'\D', '', number) for number in phone_numbers]
    
    # Save numbers to a text file
    with open('phone_numbers.txt', 'w') as output_file:
        for number in cleaned_numbers:
            output_file.write(number + '\n')
    
    return cleaned_numbers

vcf_file = 'contacts.vcf'
numbers = extract_phone_numbers(vcf_file)

print("Phone numbers have been saved to 'phone_numbers.txt'")
for number in numbers:
    #print(number)
    pass

print("Numbers : ",len(numbers))
