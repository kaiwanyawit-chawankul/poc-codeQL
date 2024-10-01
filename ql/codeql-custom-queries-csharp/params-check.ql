import csharp

from Method m
where m.getNumberOfParameters() > 20 // Adjust the threshold as needed
select m, "This method has too many parameters."
