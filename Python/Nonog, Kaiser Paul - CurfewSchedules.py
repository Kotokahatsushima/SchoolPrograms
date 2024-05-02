curfew_scheds = {
    "BlueSeniorUnderage":"Mondays, Thursdays, Fridays 10:00pm - 4:00am\nSundays, 11:00pm - 3:00am",
    "RedSeniorUnderage":"Wednesdays, Saturdays, Mondays 10:00pm - 4:00am\nSundays, 11:00pm - 3:00am",
    "GreenSeniorUnderage":"Tuesdays, Fridays, Saturdays 10:00pm - 4:00am\nSundays, 11:00pm - 3:00am",
    "Blue":"Mondays, Thursdays, 10:00pm - 4:00am\nSundays, 11:00pm - 3:00am",
    "Red":"Wednesdays, Saturdays 10:00pm - 4:00am\nSundays, 11:00pm - 3:00am",
    "Green":"Tuesdays, Fridays 10:00pm - 4:00am\nSundays, 11:00pm - 3:00am"
}
divider = '─────────────────────────────────────────────────────────────────────────────────'
def function():
    name = input(divider+"\n"+"Enter Name: ")
    age = int(input("Enter Age: "))
    districtID =  int(input("Enter District ID (1-9): "))
    if age<18 or age>60:
        if districtID in [1,3,5]:
            district_Color = curfew_scheds.get("BlueSeniorUnderage")
            print (divider+"\n"+"Name: "+name+"\n"+"Blue District Schedule: "+ district_Color+"\n"+divider)
        elif districtID in [2,4,6]:
            district_Color = curfew_scheds.get("RedSeniorUnderage")
            print (divider+"\n"+"Name: "+name+"\n"+"Red District Schedule: "+ district_Color+"\n"+divider)
        elif districtID in [7,8,9]:
            district_Color = curfew_scheds.get("GreenSeniorUnderage")
            print (divider+"\n"+"Name: "+name+"\n"+"Green District Schedule: "+ district_Color+"\n"+divider)
        else:
            print("Invalid District ID")
            function()
    else:
        if districtID in [1,3,5]:
            district_Color = curfew_scheds.get("Blue")
            print (divider+"\n"+"Name: "+name+"\n"+"Blue District Schedule: "+ district_Color+"\n"+divider)
        elif districtID in [2,4,6]:
            district_Color = curfew_scheds.get("Red")
            print (divider+"\n"+"Name: "+name+"\n"+"Red District Schedule: "+ district_Color+"\n"+divider)
        elif districtID in [7,8,9]:
            district_Color = curfew_scheds.get("Green")
            print (divider+"\n"+"+Name: "+name+"\n"+"Green District Schedule: "+ district_Color+"\n"+divider)
        else:
            print("Invalid District ID")
            function()
function()

    