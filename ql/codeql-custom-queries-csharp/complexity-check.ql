/**
 * This is an automatically generated file
 * @name Cyclomatic Complexity
 * @kind problem
 * @problem.severity error
 * @id csharp/cyclomatic-complexity
 */
import csharp

from Method m
where m.getCyclomaticComplexity() > 10 // Adjust the threshold as needed
select m, "This method has a cyclomatic complexity greater than 10."
