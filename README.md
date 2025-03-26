File Upload from Angular:
The SPA uploads a file (PDF, DOCX, or TXT).

File-to-Text Conversion:
Your IFileToTextConverterService converts the file to a string (using Tika.Net).

Resume Parsing:
The IResumeParserService processes that string, extracts structured data, and maps it to a ParsedResumeDTO.

Pre-Fill Form in Angular:
The ParsedResumeDTO is sent back to the SPA to pre-fill the candidate form.

Form Submission:
When the form is submitted, the SPA sends the data back to your WebAPI, where you map it to your domain entities 
(Candidate, Education, Experience, Skills) and persist them using your entity services and repositories.
