$(document)
    .ready(function() {
        $("#playGame")
            .on("click",
                function() {

                    var player =
                    {
                        StartingBet: $("#amount").val(),
                        TimesRolled: 0,
                        MaxWinnings: 0,
                        MaxWinnigsRolled: 0
                    };

                    var currentWinnings = player.StartingBet;
                    player.MaxWinnings = currentWinnings;


                    do {
                        player.TimesRolled++;
                        var die1 = Math.floor(Math.random() * 10 % 6 + 1);
                        var die2 = Math.floor(Math.random() * 10 % 6 + 1);

                        var sum = die1 + die2;

                        if (sum === 7) {
                            currentWinnings += 4;

                            if (player.MaxWinnings < currentWinnings) {
                                player.MaxWinnings = currentWinnings;
                                player.MaxWinnigsRolled = player.TimesRolled;

                            }
                        } else {
                            currentWinnings -= 1;
                        }


                    } while (currentWinnings > 0);

                    $("#startingBet").val(player.StartingBet);
                    document.getElementById("numberOfRolls").value = player.TimesRolled;
                    document.getElementById("maxAmountWon").value = player.MaxWinnings;
                    document.getElementById("rollAtMax").value = player.MaxWinnigsRolled;


                    console.log("Starting bet: " + player.StartingBet);
                    console.log("times played " + player.TimesRolled);
                    console.log("max winnings " + player.MaxWinnings);
                    console.log("Times rolled at maxed winnings " + player.MaxWinnigsRolled);

                    $("#resultsTable").show();
                });

        $("#playAgain")
            .on("click",
                function() {
                    $("#startingBet").val("");
                    document.getElementById("numberOfRolls").value = "";
                    document.getElementById("maxAmountWon").value = "";
                    document.getElementById("rollAtMax").value = "";

                    $("#resultsTable").hide();
                });
        $("#resultsTable").hide();
    });