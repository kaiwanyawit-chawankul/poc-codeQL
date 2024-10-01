/**
 * This is an automatically generated file
 * @name Too Many Params
 * @kind problem
 * @problem.severity error
 * @id csharp/too-many-params
 */
import csharp

from Method m
where m.getNumberOfParameters() > 20 // Adjust the threshold as needed
select m, "This method has too many parameters."
