# DiscreteSorting

This program is inspired by this video:	https://www.youtube.com/watch?v=ZZuD6iUe3Pc&ab_channel=ViktorBohush

The DiscreteSorting program allows the visualization and comparison of multiple sorting algorithms. 

The time discrete simulation works as follows: 
- let a sorter presort a copy of the array, which has to be sorted
- send a queue of changes for the visualization to the simulator
- work through one change (or multiple changes depending on the configuration) in the queue on each tick of a background timer

Currently available sorting algorithms are:  
- bubblesort
- selectionsort
- mergesort
- quicksort