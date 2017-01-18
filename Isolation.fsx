#load """paket-files/include-scripts/net451/include.main.group.fsx"""

open Expecto

let test =
  testCase "universe exists" <| fun _ ->
    let subject = true
    Expect.isTrue subject "I compute, therefore I am."

runTests defaultConfig test