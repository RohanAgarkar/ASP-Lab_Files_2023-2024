import os
from argparse import ArgumentParser
import xml.etree.ElementTree as ET

def update_xml(xml_file_path, element_name, new_value):
   tree = ET.parse(xml_file_path)
   root = tree.getroot()

   # Find the element with the specified name
   element = root.find(".//{}".format(element_name))

   if element is not None:
       # Update the element's text content
       element.text = new_value
   else:
       print("Element '{}' not found in the XML file.".format(element_name))
       return

   # Save the modified XML back to the file
   tree.write(xml_file_path)

def main():
   parser = ArgumentParser(usage="%(prog)s [ClassName]")
   parser.add_argument('-c', '--ClassName', help="Enter your program name.", required=False)
   args = parser.parse_args()
   if args.ClassName:
       # Change the Mvc.csproj in case you are changing the project/ namespace
       update_xml("Mvc.csproj", "StartupObject", args.ClassName)
   os.system('dotnet build')
   os.system('dotnet run')

if __name__ == "__main__":
   main()
