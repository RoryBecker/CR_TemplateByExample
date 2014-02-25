CR_TemplateByExample
====================

CodeRush plugin designed to help create simple templates.

Initial version includes 2 additional commands: CreateTempTemplate and ExecuteTempTemplate.

(For information on binding these and other commands to shortcuts, see http://community.devexpress.com/blogs/rorybecker/archive/2010/10/05/binding-keys-in-coderush.aspx)

Usage
=====

 - Highlight code
 - Invoke CreateTempTemplate
 - Specify lines of Text in 'Substitutions' 
 
 Substitutions are elements of text within the template, which will be substituted for user input at run time.
 The first instance of a Substitution will be replaced with a Field.
 Successive instances of Substitution will be linked to the Field and will change as it does.

 - Click Ok to save the TempTemplate.
 - Invoke the ExecuteTempTemplaste to execute the TempTemplaste as if triggered directly.
 
 
