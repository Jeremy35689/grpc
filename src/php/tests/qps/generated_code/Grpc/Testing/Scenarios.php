<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: src/proto/grpc/testing/control.proto

namespace Grpc\Testing;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A set of scenarios to be run with qps_json_driver
 *
 * Generated from protobuf message <code>grpc.testing.Scenarios</code>
 */
class Scenarios extends \Google\Protobuf\Internal\Message
{
    /**
     * Generated from protobuf field <code>repeated .grpc.testing.Scenario scenarios = 1;</code>
     */
    private $scenarios;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Grpc\Testing\Scenario[]|\Google\Protobuf\Internal\RepeatedField $scenarios
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Src\Proto\Grpc\Testing\Control::initOnce();
        parent::__construct($data);
    }

    /**
     * Generated from protobuf field <code>repeated .grpc.testing.Scenario scenarios = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getScenarios()
    {
        return $this->scenarios;
    }

    /**
     * Generated from protobuf field <code>repeated .grpc.testing.Scenario scenarios = 1;</code>
     * @param \Grpc\Testing\Scenario[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setScenarios($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Grpc\Testing\Scenario::class);
        $this->scenarios = $arr;

        return $this;
    }

}

