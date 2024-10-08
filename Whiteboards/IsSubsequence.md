# 392. Is Subsequence

Given two strings `s` and `t`, return `true` if `s` is a subsequence of `t`, or `false` otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., `"ace"` is a subsequence of `"abcde"` while `"aec"` is not).

Example 1:

Input: `s = "abc", t = "ahbgdc"`
Output: `true`


Example 2:

Input: `s = "axc", t = "ahbgdc"`
Output: `false`

## Whiteboard

![IsSubsequence](./img/IsSubsequence.png)

## Solution

[IsSubsequence.cs](../LeetCode/IsSubsequence.cs)

## Big O

- Time complexity: O(n) - In the worst case, the algorithm will scan through the entire string t once, making the time complexity dependent on the length of t. total number of iterations is therefore proportional to the length of t.

- Space complexity: O(1)