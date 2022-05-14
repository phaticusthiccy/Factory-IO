function reset()
    reset ()
    
    return 
end

-- Main
local boolin0, boolin1, boolout0, boolout1, boolout2, boolout3, boolout4, boolout14, boolout15

boolin0 = string.lower(io.read()) == "true")
boolin1 = string.lower(io.read()) == "true")
boolout0 = string.lower(io.read()) == "true")
boolout1 = string.lower(io.read()) == "true")
boolout2 = string.lower(io.read()) == "true")
boolout3 = string.lower(io.read()) == "true")
boolout4 = string.lower(io.read()) == "true")
boolout14 = string.lower(io.read()) == "true")
boolout15 = string.lower(io.read()) == "true")
if boolin1 then
    io.write("Stopped", "\n")
    repeat
        reset ()
    until not (boolin1)
else
    boolin0 = true
    io.write("Running", "\n")
    while true do
        boolin1 = string.lower(io.read()) == "true")
        while not boolin1 do
            io.write("Stopped", "\n")
            repeat
                reset ()
            until not (boolin1)
        end
    end
end
