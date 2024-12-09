from unidecode import unidecode

def convert_to_ascii(input_file, output_file):
    with open(input_file, 'r', encoding='utf-8') as infile:
        content = infile.read()
    
    ascii_content = unidecode(content)
    
    with open(output_file, 'w', encoding='ascii') as outfile:
        outfile.write(ascii_content)

# Usage
input_file = 'phone_numbers.txt'
output_file = 'phone_numbers_ascii.txt'
convert_to_ascii(input_file, output_file)

print(f"Converted file saved as {output_file}")
