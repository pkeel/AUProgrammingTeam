cycleCount :: Int -> Int
cycleCount 1 = 1
cycleCount n = cycleCounter 0 n

cycleCounter :: Int -> Int -> Int
cycleCounter c n | n == 1 = c + 1
                 | n `rem` 2 == 0 = cycleCounter (c+1) (n`div`2) 
                 | otherwise = cycleCounter (c+1) (3*n+1)

maxCycle :: (Int,Int) -> Int
maxCycle (x,y) | x > y = error "cannot do that range"
               | x == 0 && y == 0 = 0
               | otherwise = maxCycle' x y 0

maxCycle' :: Int -> Int -> Int -> Int
maxCycle' x y m | x == y = max m $ cycleCount x
                | otherwise = maxCycle' (x + 1) y (max m (cycleCount x))