local os = os or {}
local date = os.date
local modf = math.modf
local format = string.format

local Time = { Day = 24 * 60 * 60, Hour = 60 * 60, Min = 60, Second = 1 }

--[[
    将当前时间转换为lua中标准的date形式
    @param: time 当前时间，单位（秒）
]]
function os.ToDate(time)
    return date("%Y-%m-%d %H:%M:%S", time) 
end

--[[
    将当前时间转换为{小时，分钟，秒}的形式
    @param: time 当前时间，单位（秒）
]]
function os.ToWholeTime(time)
    local hour, _ = modf(time / Time.Hour)
    local min, _ = modf((time - hour * Time.Hour) / Time.Min)
    local sec = time - hour * Time.Hour - min * Time.Min
    return { hour, min, sec }
end
--[[
    将当前时间转换为XX:XX:XX格式
    @param: hour 小时
    @param: min 分钟
    @param: second 秒
]]
function os.ToTimeString(hour, min, second)
    local text = ""
    if hour and hour ~= 0 then
        text = format("%02d:%02d:%02d", hour, min, second)
        return text
    end

    if min and min ~= 0 then
        text = format("%02d:%02d", min, second)
        return text
    end

    if second then
        text = format("00:%02d", second)
        return text
    end
    return ""
end

function os.ToFormatString(fmt, time)
    return date(fmt, time) 
end





