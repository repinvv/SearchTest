# Task
There is a very large set of records representing Posts on Q&A site having some fields in them.
User is able to configure a filter that is applied to them by specifing what subfilters are applied to each record.
If any of filters is not satisfied for a record then the compound filter does not match the record.
Vice versa, the filter matches the record if all of subfilters are satisfied.

The list of filters applied to the data set is specified as a structure with few boolean fields.
The structure is passed along with the data set to a function.

Your task is to create the most performant function among others using C# language.
You should create 2 more tests (one for validity and one for measurement) in the solution by coping existing tests and invoking your code.
