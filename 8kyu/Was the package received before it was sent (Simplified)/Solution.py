def was_package_received_yesterday(tz_from, tz_to, start, duration):
    tz_diff = tz_to - tz_from
    result = start + tz_diff + duration
    return result < 0